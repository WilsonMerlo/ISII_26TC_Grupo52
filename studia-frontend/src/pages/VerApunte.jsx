// src/pages/VerApunte.jsx
import React, { useState, useRef, useEffect, useCallback } from 'react';

// ---------------------------------------------------------------------------
// Helpers
// ---------------------------------------------------------------------------
const queryCmd = (cmd) => document.queryCommandState(cmd);

const execCmd = (cmd, value = null) => {
    document.execCommand(cmd, false, value);
};

// ---------------------------------------------------------------------------
// Hook: estado activo de la toolbar
// ---------------------------------------------------------------------------
const useFormatState = (editorRef) => {
    const [activeFormats, setActiveFormats] = useState({
        bold: false,
        italic: false,
        underline: false,
        insertUnorderedList: false,
        insertOrderedList: false,
    });

    const updateFormats = useCallback(() => {
        setActiveFormats({
            bold: queryCmd('bold'),
            italic: queryCmd('italic'),
            underline: queryCmd('underline'),
            insertUnorderedList: queryCmd('insertUnorderedList'),
            insertOrderedList: queryCmd('insertOrderedList'),
        });
    }, []);

    useEffect(() => {
        const editor = editorRef.current;
        if (!editor) return;
        editor.addEventListener('keyup', updateFormats);
        editor.addEventListener('mouseup', updateFormats);
        editor.addEventListener('selectionchange', updateFormats);
        document.addEventListener('selectionchange', updateFormats);
        return () => {
            editor.removeEventListener('keyup', updateFormats);
            editor.removeEventListener('mouseup', updateFormats);
            editor.removeEventListener('selectionchange', updateFormats);
            document.removeEventListener('selectionchange', updateFormats);
        };
    }, [editorRef, updateFormats]);

    return activeFormats;
};

// ---------------------------------------------------------------------------
// Toast de feedback
// ---------------------------------------------------------------------------
const Toast = ({ status }) => {
    if (!status) return null;

    const styles = {
        loading: 'bg-white text-slate-600 border border-slate-200',
        success: 'bg-[#3A5A82] text-white',
        error: 'bg-red-500 text-white',
    };

    const icons = {
        loading: (
            <svg className="animate-spin h-4 w-4" viewBox="0 0 24 24" fill="none">
                <circle className="opacity-25" cx="12" cy="12" r="10" stroke="currentColor" strokeWidth="4" />
                <path className="opacity-75" fill="currentColor" d="M4 12a8 8 0 018-8V0C5.373 0 0 5.373 0 12h4z" />
            </svg>
        ),
        success: <span className="material-symbols-outlined text-[18px]">check_circle</span>,
        error: <span className="material-symbols-outlined text-[18px]">error</span>,
    };

    const messages = {
        loading: 'Guardando…',
        success: '¡Guardado correctamente!',
        error: 'Error al guardar. Intentá de nuevo.',
    };

    return (
        <div
            className={`fixed bottom-8 left-1/2 -translate-x-1/2 z-50 flex items-center gap-2 px-5 py-3 rounded-full shadow-xl font-semibold text-sm transition-all duration-300 ${styles[status]}`}
        >
            {icons[status]}
            {messages[status]}
        </div>
    );
};

// ---------------------------------------------------------------------------
// Componente principal
// ---------------------------------------------------------------------------
const VerApunte = ({ apunteSeleccionado, onVolver, onGuardar }) => {
    const editorRef = useRef(null);
    const activeFormats = useFormatState(editorRef);

    const [titulo, setTitulo] = useState('');
    const [saveStatus, setSaveStatus] = useState(null); // null | 'loading' | 'success' | 'error'

    // Cargar datos al montar o cuando cambia el apunte
    useEffect(() => {
        if (!apunteSeleccionado) return;
        const tituloInicial = apunteSeleccionado.titulo || apunteSeleccionado.Titulo || '';
        const contenidoInicial = apunteSeleccionado.contenido || apunteSeleccionado.Contenido || '';
        setTitulo(tituloInicial);
        if (editorRef.current) {
            editorRef.current.innerHTML = contenidoInicial;
        }
    }, [apunteSeleccionado]);

    // Limpiar toast automáticamente
    useEffect(() => {
        if (saveStatus === 'success' || saveStatus === 'error') {
            const timer = setTimeout(() => setSaveStatus(null), 2500);
            return () => clearTimeout(timer);
        }
    }, [saveStatus]);

    // -----------------------------------------------------------------------
    // Handlers de toolbar
    // -----------------------------------------------------------------------
    const handleBold = () => {
        editorRef.current?.focus();
        execCmd('bold');
    };

    const handleItalic = () => {
        const editor = editorRef.current;
        if (!editor) return;
        editor.focus();

        const sel = window.getSelection();
        if (!sel || sel.rangeCount === 0) return;

        // Intentar con execCommand primero; si el texto ya tiene font-style forzado usamos insertHTML
        const alreadyItalic = document.queryCommandState('italic');
        if (alreadyItalic) {
            // Quitar cursiva
            execCmd('italic');
        } else {
            // Aplicar: primero intentar execCommand nativo
            execCmd('italic');
            // Verificar que se aplicó revisando el computed style del nodo seleccionado
            const node = sel.anchorNode?.parentElement;
            if (node) {
                const computed = window.getComputedStyle(node).fontStyle;
                if (computed !== 'italic' && computed !== 'oblique') {
                    // execCommand no funcionó visualmente → usar insertHTML con <em> y estilo inline
                    document.execCommand('undo', false, null);
                    const range = sel.getRangeAt(0);
                    const selectedText = range.toString();
                    if (selectedText) {
                        range.deleteContents();
                        const em = document.createElement('em');
                        em.style.fontStyle = 'italic';
                        em.textContent = selectedText;
                        range.insertNode(em);
                        // Mover cursor al final del em
                        range.setStartAfter(em);
                        range.setEndAfter(em);
                        sel.removeAllRanges();
                        sel.addRange(range);
                    }
                }
            }
        }
    };

    const handleUnderline = () => {
        editorRef.current?.focus();
        execCmd('underline');
    };

    const handleBulletList = () => {
        editorRef.current?.focus();
        execCmd('insertUnorderedList');
    };

    const handleNumberedList = () => {
        editorRef.current?.focus();
        execCmd('insertOrderedList');
    };

    // -----------------------------------------------------------------------
    // Guardar
    // -----------------------------------------------------------------------
    const handleGuardar = async () => {
        if (!apunteSeleccionado) return;
        const contenidoActualizado = editorRef.current?.innerHTML || '';

        setSaveStatus('loading');
        try {
            // Si el padre pasa onGuardar, delegar; sino hacer fetch directo
            if (typeof onGuardar === 'function') {
                await onGuardar({
                    ...apunteSeleccionado,
                    titulo,
                    Titulo: titulo,
                    contenido: contenidoActualizado,
                    Contenido: contenidoActualizado,
                });
            } else {
                // Fallback: PATCH/PUT genérico al endpoint de la API
                const id = apunteSeleccionado.id || apunteSeleccionado.Id || apunteSeleccionado._id;
                const res = await fetch(`/api/apuntes/${id}`, {
                    method: 'PUT',
                    headers: { 'Content-Type': 'application/json' },
                    body: JSON.stringify({ titulo, contenido: contenidoActualizado }),
                });
                if (!res.ok) throw new Error('Error en el servidor');
            }
            setSaveStatus('success');
        } catch (err) {
            console.error('Error al guardar:', err);
            setSaveStatus('error');
        }
    };

    // -----------------------------------------------------------------------
    // UI helpers
    // -----------------------------------------------------------------------
    const toolbarBtnClass = (active) =>
        `p-2 rounded-lg transition-all duration-150 ${
            active
                ? 'bg-[#3A5A82] text-white shadow-inner'
                : 'text-[#586064] hover:text-[#3A5A82] hover:bg-slate-100'
        }`;

    // -----------------------------------------------------------------------
    // Render sin apunte
    // -----------------------------------------------------------------------
    if (!apunteSeleccionado) {
        return (
            <div className="flex-1 p-8 text-center text-slate-500 font-['Inter']">
                <button onClick={onVolver} className="mb-4 text-[#3A5A82] hover:underline font-bold">
                    ← Volver a la lista
                </button>
                <p>No se seleccionó ningún apunte.</p>
            </div>
        );
    }

    // -----------------------------------------------------------------------
    // Render principal
    // -----------------------------------------------------------------------
    return (
        <div className="flex-1 flex flex-col bg-[#f1f4f6] font-['Inter'] relative" style={{ minHeight: 0, overflow: 'hidden' }}>

            {/* Modales y toasts */}
            <Toast status={saveStatus} />

            {/* Acciones superiores (Volver + Guardar) */}
            <div className="absolute top-6 left-8 flex items-center gap-3 z-40">
                <button
                    onClick={onVolver}
                    className="flex items-center gap-1.5 text-slate-500 hover:text-[#3A5A82] transition-colors font-semibold text-sm"
                >
                    <span className="material-symbols-outlined text-lg">arrow_back</span>
                    Volver
                </button>

                <span className="text-slate-300 select-none">|</span>

                <button
                    onClick={handleGuardar}
                    disabled={saveStatus === 'loading'}
                    className={`flex items-center gap-1.5 px-4 py-1.5 rounded-full text-sm font-semibold transition-all duration-200 shadow-sm
                        ${saveStatus === 'loading'
                            ? 'bg-[#3A5A82]/60 text-white cursor-not-allowed'
                            : 'bg-[#3A5A82] text-white hover:bg-[#2e4a6e] hover:shadow-md active:scale-95'
                        }`}
                >
                    {saveStatus === 'loading' ? (
                        <>
                            <svg className="animate-spin h-3.5 w-3.5" viewBox="0 0 24 24" fill="none">
                                <circle className="opacity-25" cx="12" cy="12" r="10" stroke="currentColor" strokeWidth="4" />
                                <path className="opacity-75" fill="currentColor" d="M4 12a8 8 0 018-8V0C5.373 0 0 5.373 0 12h4z" />
                            </svg>
                            Guardando…
                        </>
                    ) : (
                        <>
                            <span className="material-symbols-outlined text-[16px]">save</span>
                            Guardar
                        </>
                    )}
                </button>
            </div>

            {/* Lienzo principal */}
            <section className="flex-1 overflow-y-auto" style={{ minHeight: 0 }}>
                <div className="max-w-3xl mx-auto py-16 px-8">

                    {/* Toolbar flotante (Glassmorphism) */}
                    <div className="glass-toolbar sticky top-4 mb-12 p-1 rounded-full border border-white/40 shadow-xl flex items-center gap-1 justify-center max-w-fit mx-auto z-30 bg-white/80 backdrop-blur-md">

                        {/* Formato básico */}
                        <div className="flex items-center px-2 border-r border-[#abb3b7]/20">
                            <button
                                onMouseDown={(e) => { e.preventDefault(); handleBold(); }}
                                className={toolbarBtnClass(activeFormats.bold)}
                                title="Negrita"
                            >
                                <span className="material-symbols-outlined text-[20px]">format_bold</span>
                            </button>
                            <button
                                onMouseDown={(e) => { e.preventDefault(); handleItalic(); }}
                                className={toolbarBtnClass(activeFormats.italic)}
                                title="Cursiva"
                            >
                                <span className="material-symbols-outlined text-[20px]">format_italic</span>
                            </button>
                            <button
                                onMouseDown={(e) => { e.preventDefault(); handleUnderline(); }}
                                className={toolbarBtnClass(activeFormats.underline)}
                                title="Subrayado"
                            >
                                <span className="material-symbols-outlined text-[20px]">format_underlined</span>
                            </button>
                        </div>

                        {/* Listas */}
                        <div className="flex items-center px-2">
                            <button
                                onMouseDown={(e) => { e.preventDefault(); handleBulletList(); }}
                                className={toolbarBtnClass(activeFormats.insertUnorderedList)}
                                title="Lista de viñetas"
                            >
                                <span className="material-symbols-outlined text-[20px]">format_list_bulleted</span>
                            </button>
                            <button
                                onMouseDown={(e) => { e.preventDefault(); handleNumberedList(); }}
                                className={toolbarBtnClass(activeFormats.insertOrderedList)}
                                title="Lista numerada"
                            >
                                <span className="material-symbols-outlined text-[20px]">format_list_numbered</span>
                            </button>
                        </div>
                    </div>

                    {/* Título editable */}
                    <input
                        className="w-full bg-transparent border-none focus:ring-0 text-5xl font-extrabold font-['Manrope'] tracking-tight text-[#2b3437] mb-8 block outline-none placeholder-slate-300"
                        type="text"
                        value={titulo}
                        onChange={(e) => setTitulo(e.target.value)}
                        placeholder="Sin título"
                    />

                    {/* Cuerpo editable */}
                    <div
                        ref={editorRef}
                        contentEditable
                        suppressContentEditableWarning
                        spellCheck
                        data-placeholder="Empezá a escribir tu apunte…"
                        className="
                            prose prose-slate max-w-none text-lg text-[#465365] leading-relaxed font-body
                            focus:outline-none min-h-[300px]
                            [&_a]:text-[#3A5A82] [&_a]:underline
                            [&_em]:italic [&_i]:italic
                            [&_strong]:font-bold [&_b]:font-bold
                            [&_u]:underline
                            [&_blockquote]:border-l-4 [&_blockquote]:border-[#3A5A82]
                            [&_blockquote]:pl-4 [&_blockquote]:italic [&_blockquote]:text-[#586064]
                            [&_blockquote]:bg-[#eef1f4] [&_blockquote]:rounded-r-lg [&_blockquote]:py-2
                            [&_ul]:list-disc [&_ul]:pl-6
                            [&_ol]:list-decimal [&_ol]:pl-6
                            empty:before:content-[attr(data-placeholder)] empty:before:text-slate-400
                        "
                        style={{ caretColor: '#3A5A82', fontStyle: 'normal' }}
                    />

                </div>
            </section>
        </div>
    );
};

export default VerApunte;