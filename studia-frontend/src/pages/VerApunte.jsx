// src/pages/VerApunte.jsx
import React from 'react';

const VerApunte = ({ apunteSeleccionado, onVolver }) => {

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

    // Leemos los datos de la BD
    const tituloFinal = apunteSeleccionado.titulo || apunteSeleccionado.Titulo || "Sin Título";
    const contenidoHTML = apunteSeleccionado.contenido || apunteSeleccionado.Contenido || "<p>Este apunte no tiene contenido guardado.</p>";

    return (
        <div className="flex-1 flex overflow-hidden bg-[#f1f4f6] font-['Inter'] relative">
            
            {/* Botón de Volver (Flotante arriba a la izquierda del lienzo) */}
            <button 
                onClick={onVolver}
                className="absolute top-6 left-8 flex items-center gap-2 text-slate-500 hover:text-[#3A5A82] transition-colors z-40 font-semibold"
            >
                <span className="material-symbols-outlined text-lg">arrow_back</span>
                Volver
            </button>

            {/* Lienzo Principal de Lectura/Escritura */}
            <section className="flex-1 overflow-y-auto">
                <div className="max-w-3xl mx-auto py-16 px-8">
                    
                    {/* Barra de herramientas flotante (Glassmorphism) */}
                    <div className="glass-toolbar sticky top-4 mb-12 p-1 rounded-full border border-white/40 shadow-xl flex items-center gap-1 justify-center max-w-fit mx-auto z-30 bg-white/80 backdrop-blur-md">
                        <div className="flex items-center px-2 border-r border-[#abb3b7]/20">
                            <button className="p-2 text-[#586064] hover:text-[#3A5A82] transition-colors" title="Negrita">
                                <span className="material-symbols-outlined text-[20px]">format_bold</span>
                            </button>
                            <button className="p-2 text-[#586064] hover:text-[#3A5A82] transition-colors" title="Cursiva">
                                <span className="material-symbols-outlined text-[20px]">format_italic</span>
                            </button>
                            <button className="p-2 text-[#586064] hover:text-[#3A5A82] transition-colors" title="Subrayado">
                                <span className="material-symbols-outlined text-[20px]">format_underlined</span>
                            </button>
                        </div>
                        <div className="flex items-center px-2 border-r border-[#abb3b7]/20">
                            <button className="p-2 text-[#586064] hover:text-[#3A5A82] transition-colors" title="Lista de viñetas">
                                <span className="material-symbols-outlined text-[20px]">format_list_bulleted</span>
                            </button>
                            <button className="p-2 text-[#586064] hover:text-[#3A5A82] transition-colors" title="Lista numerada">
                                <span className="material-symbols-outlined text-[20px]">format_list_numbered</span>
                            </button>
                            <button className="p-2 text-[#586064] hover:text-[#3A5A82] transition-colors" title="Lista de verificación">
                                <span className="material-symbols-outlined text-[20px]">checklist</span>
                            </button>
                        </div>
                        <div className="flex items-center px-2">
                            <button className="p-2 text-[#586064] hover:text-[#3A5A82] transition-colors" title="Enlace">
                                <span className="material-symbols-outlined text-[20px]">link</span>
                            </button>
                            <button className="p-2 text-[#586064] hover:text-[#3A5A82] transition-colors" title="Imagen">
                                <span className="material-symbols-outlined text-[20px]">image</span>
                            </button>
                            <button className="p-2 text-[#586064] hover:text-[#3A5A82] transition-colors" title="Cita">
                                <span className="material-symbols-outlined text-[20px]">format_quote</span>
                            </button>
                        </div>
                    </div>

                    {/* Título del Apunte */}
                    <input 
                        className="w-full bg-transparent border-none focus:ring-0 text-5xl font-extrabold font-['Manrope'] tracking-tight text-[#2b3437] mb-8 block outline-none" 
                        type="text" 
                        readOnly
                        value={tituloFinal} 
                    />
                    
                    {/* Cuerpo del Apunte (Renderizado de la BD) */}
                    <div className="prose prose-slate max-w-none text-lg text-[#465365] leading-relaxed font-body">
                        {/* Se inyecta el HTML guardado desde ReactQuill */}
                        <div dangerouslySetInnerHTML={{ __html: contenidoHTML }} />
                    </div>

                </div>
            </section>

            

        </div>
    );
};

export default VerApunte;