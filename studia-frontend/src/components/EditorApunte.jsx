import React, { useState } from 'react';
import ReactQuill from 'react-quill';
import 'react-quill/dist/quill.snow.css'; // Estilos base de Quill
import { apunteService } from '../services/apunteService'; // Asegúrate de que la ruta sea correcta

const VistaEditorApunte = ({ idMateriaActiva = 1, nombreMateria = "Materia Desconocida", onVolver }) => {
    const [titulo, setTitulo] = useState('');
    const [contenidoHtml, setContenidoHtml] = useState('');

    // Configuramos las opciones de la barra de herramientas de Quill
    const modulosQuill = {
        toolbar: [
            [{ 'header': [1, 2, 3, false] }],
            ['bold', 'italic', 'underline', 'strike'],
            [{ 'list': 'ordered'}, { 'list': 'bullet' }],
            ['link', 'image', 'blockquote'],
            ['clean'] // Botón para remover formato
        ],
    };

    const guardarApunte = async () => {
        if (!titulo.trim() || !contenidoHtml.trim()) {
            return alert("El apunte debe tener título y contenido.");
        }

        const nuevoApunte = {
            id_materia: idMateriaActiva,
            titulo: titulo, // Si tu backend no acepta titulo, puedes concatenarlo al contenido como un <h1>
            contenido: contenidoHtml, 
            fecha_creacion: new Date().toISOString()
        };

        try {
            await apunteService.guardar(nuevoApunte);
            alert("¡Apunte guardado con éxito!");
        } catch (error) {
            console.error("Fallo al guardar", error);
            alert("Error al guardar el apunte.");
        }
    };

    return (
        <div style={estilos.workspaceWrap}>
            {/* Header del Espacio de Trabajo */}
            <header style={estilos.headerEditor}>
                <div style={estilos.headerLeft}>
                    <button style={estilos.btnVolver} onClick={onVolver}>
                        <span style={estilos.iconoMaterial}>arrow_back</span>
                    </button>
                    <div style={estilos.materiaTag}>{nombreMateria}</div>
                </div>
                
                <div style={estilos.headerRight}>
                     <div style={estilos.estadoGuardado}>
                        <span style={estilos.iconoMaterialMini}>cloud_done</span>
                        Guardado automático
                    </div>
                    <button style={estilos.btnGuardarPrincipal} onClick={guardarApunte}>
                        Guardar Apunte
                    </button>
                </div>
            </header>

            {/* Zona del Editor y Sidebar Derecho (Split View) */}
            <div style={estilos.editorSplitView}>
                
                {/* 1. LIENZO PRINCIPAL DE ESCRITURA */}
                <section style={estilos.lienzoPrincipal}>
                    <div style={estilos.contenedorEscritura}>
                        
                        {/* Título GIGANTE (Como en el diseño que mandaste) */}
                        <input 
                            type="text" 
                            placeholder="Escribe tu título aquí..." 
                            value={titulo}
                            onChange={(e) => setTitulo(e.target.value)}
                            style={estilos.inputTitulo}
                        />

                        {/* El Editor Real (React Quill) */}
                        <div style={estilos.quillWrapper}>
                            <ReactQuill 
                                theme="snow" 
                                value={contenidoHtml} 
                                onChange={setContenidoHtml} 
                                modules={modulosQuill}
                                placeholder="Comienza a escribir tus notas de la clase aquí..."
                                style={estilos.quillInstancia}
                            />
                        </div>

                    </div>
                </section>

                {/* 2. SIDEBAR DERECHO (Resumen / Pomodoro Mini) */}
                <aside style={estilos.sidebarDerecho}>
                    {/* Esquema de la nota (Simulado por ahora) */}
                    <div style={estilos.tarjetaSidebar}>
                        <h4 style={estilos.tituloSidebar}>Esquema de la Nota</h4>
                        <ul style={estilos.listaEsquema}>
                            <li style={estilos.itemEsquemaActivo}>Introducción</li>
                            <li style={estilos.itemEsquema}>I. Conceptos Clave</li>
                            <li style={estilos.itemEsquema}>II. Desarrollo</li>
                        </ul>
                    </div>

                    {/* Meta Info (Conteo de Palabras) */}
                    <div style={{...estilos.tarjetaSidebar, marginTop: '20px'}}>
                        <h4 style={estilos.tituloSidebar}>Información</h4>
                        <div style={estilos.metaFila}>
                            <span>Caracteres:</span>
                            <strong>{contenidoHtml.replace(/<[^>]*>?/gm, '').length}</strong>
                        </div>
                        <div style={estilos.metaFila}>
                            <span>Modo de estudio:</span>
                            <span style={estilos.tagDeepWork}>Deep Work</span>
                        </div>
                    </div>
                </aside>
            </div>
        </div>
    );
};

// --- ESTILOS INLINE (Traducción del Tailwind y HTML proporcionado) ---
const estilos = {
    workspaceWrap: { display: 'flex', flexDirection: 'column', height: '100vh', backgroundColor: '#F9FBFF', width: '100%' },
    
    // Header
    headerEditor: { display: 'flex', justifyContent: 'space-between', alignItems: 'center', padding: '15px 30px', backgroundColor: 'white', borderBottom: '1px solid #E8EBFF', zIndex: 10 },
    headerLeft: { display: 'flex', alignItems: 'center', gap: '15px' },
    btnVolver: { background: 'none', border: '1px solid #E8EBFF', borderRadius: '8px', padding: '8px', cursor: 'pointer', color: '#3A56AF', display: 'flex', alignItems: 'center', justifyContent: 'center' },
    materiaTag: { backgroundColor: '#F6F8FE', color: '#3A56AF', padding: '5px 12px', borderRadius: '6px', fontSize: '0.85rem', fontWeight: '600' },
    headerRight: { display: 'flex', alignItems: 'center', gap: '20px' },
    estadoGuardado: { display: 'flex', alignItems: 'center', gap: '5px', color: '#9EA5BA', fontSize: '0.8rem' },
    iconoMaterialMini: { fontSize: '1rem' },
    btnGuardarPrincipal: { backgroundColor: '#3A56AF', color: 'white', border: 'none', padding: '10px 20px', borderRadius: '8px', fontWeight: '600', cursor: 'pointer', transition: 'all 0.2s' },

    // Layout
    editorSplitView: { display: 'flex', flex: 1, overflow: 'hidden' },
    
    // Lienzo Principal (Izquierda)
    lienzoPrincipal: { flex: 1, overflowY: 'auto', padding: '40px 0', backgroundColor: '#F9FBFF' },
    contenedorEscritura: { maxWidth: '800px', margin: '0 auto', backgroundColor: 'white', padding: '50px 60px', borderRadius: '15px', boxShadow: '0 4px 20px rgba(0,0,0,0.03)', border: '1px solid #E8EBFF', minHeight: '800px' },
    
    inputTitulo: { width: '100%', border: 'none', outline: 'none', fontSize: '2.5rem', fontWeight: '800', color: '#2D3247', marginBottom: '30px', backgroundColor: 'transparent' },
    
    // Configuración para sobreescribir los estilos feos por defecto de Quill
    quillWrapper: { 
        width: '100%',
        /* Truco CSS in JS para Quill: Envolvemos la instancia para que herede nuestras fuentes */
        fontFamily: "'Inter', sans-serif" 
    },
    quillInstancia: { height: '500px' }, // Altura inicial del editor

    // Sidebar Derecho (Esquema/Meta)
    sidebarDerecho: { width: '300px', backgroundColor: 'white', borderLeft: '1px solid #E8EBFF', padding: '30px 20px', overflowY: 'auto' },
    tarjetaSidebar: { backgroundColor: '#F6F8FE', borderRadius: '12px', padding: '20px' },
    tituloSidebar: { fontSize: '0.8rem', textTransform: 'uppercase', color: '#9EA5BA', fontWeight: '700', letterSpacing: '1px', margin: '0 0 15px 0' },
    listaEsquema: { listStyle: 'none', padding: 0, margin: 0, display: 'flex', flexDirection: 'column', gap: '10px' },
    itemEsquemaActivo: { fontSize: '0.9rem', color: '#3A56AF', fontWeight: '600', borderLeft: '2px solid #3A56AF', paddingLeft: '10px' },
    itemEsquema: { fontSize: '0.9rem', color: '#9EA5BA', paddingLeft: '12px', cursor: 'pointer' },
    metaFila: { display: 'flex', justifyContent: 'space-between', fontSize: '0.85rem', color: '#4A5568', marginBottom: '10px' },
    tagDeepWork: { backgroundColor: '#3A56AF', color: 'white', fontSize: '0.7rem', padding: '2px 8px', borderRadius: '4px', fontWeight: 'bold' }
};

export default VistaEditorApunte;