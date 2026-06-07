import React, { useState } from 'react';
import { usuarioService } from '../services/usuarioService';

const MisDatosDashboard = () => {
    const [editando, setEditando] = useState(false);
    const [guardando, setGuardando] = useState(false);

    const [nombre, setNombre] = useState(localStorage.getItem('nombreUsuario') || '');
    const [correo, setCorreo] = useState(localStorage.getItem('correoUsuario') || '');
    const [contrasenaActual, setContrasenaActual] = useState('');
    const [nuevaContrasena, setNuevaContrasena] = useState('');

    const guardarCambios = async () => {
        try {
            setGuardando(true);

            const idUsuario = localStorage.getItem('idUsuario');

            await usuarioService.actualizar(idUsuario, {
                idUsuario: Number(idUsuario),
                nombre,
                correo,
                contrasena: nuevaContrasena || ''
            });

            localStorage.setItem('nombreUsuario', nombre);
            localStorage.setItem('correoUsuario', correo);

            setContrasenaActual('');
            setNuevaContrasena('');
            setEditando(false);
        } catch (error) {
            console.error('Error guardando datos:', error);
            alert('No se pudieron guardar los datos.');
        } finally {
            setGuardando(false);
        }
    };

    return (
        <div style={estilos.contenedor}>
            <div style={estilos.encabezado}>
                <p style={estilos.subtitulo}>Panel de Usuario</p>
                <h2 style={estilos.titulo}>
                    Tu espacio, <span style={estilos.tituloAzul}>tus reglas.</span>
                </h2>
                <p style={estilos.descripcion}>
                    Ajusta tu entorno de aprendizaje para maximizar la concentración y el rendimiento cognitivo.
                </p>
            </div>

            <div style={estilos.grid}>
                <section style={estilos.cardGrande}>
                    <div style={estilos.cardHeader}>
                        <div style={estilos.iconoCaja}>
                            <span className="material-symbols-outlined">person</span>
                        </div>
                        <h3 style={estilos.cardTitulo}>Datos Personales</h3>
                    </div>

                    <div style={estilos.formulario}>
                        <div style={estilos.fila}>
                            <div style={estilos.campo}>
                                <label style={estilos.label}>Nombre</label>
                                <input
                                    style={{
                                        ...estilos.input,
                                        ...(editando ? {} : estilos.inputDeshabilitado)
                                    }}
                                    type="text"
                                    value={nombre}
                                    disabled={!editando}
                                    onChange={(e) => setNombre(e.target.value)}
                                />
                            </div>

                            <div style={estilos.campo}>
                                <label style={estilos.label}>Correo Electrónico</label>
                                <input
                                    style={{
                                        ...estilos.input,
                                        ...(editando ? {} : estilos.inputDeshabilitado)
                                    }}
                                    type="email"
                                    value={correo}
                                    disabled={!editando}
                                    onChange={(e) => setCorreo(e.target.value)}
                                />
                            </div>
                        </div>

                        {!editando && (
                            <button
                                type="button"
                                style={estilos.btnEditar}
                                onClick={() => setEditando(true)}
                            >
                                Habilitar edición
                            </button>
                        )}
                    </div>
                </section>

                <section style={estilos.cardChica}>
                    <div style={estilos.cardHeader}>
                        <div style={estilos.iconoCajaSecundaria}>
                            <span className="material-symbols-outlined">lock</span>
                        </div>
                        <h3 style={estilos.cardTitulo}>Seguridad</h3>
                    </div>

                    <div style={estilos.formulario}>
                        <div style={estilos.campo}>
                            <label style={estilos.label}>Contraseña actual</label>
                            <input
                                style={{
                                    ...estilos.input,
                                    ...(editando ? {} : estilos.inputDeshabilitado)
                                }}
                                type="password"
                                placeholder="••••••••"
                                value={contrasenaActual}
                                disabled={!editando}
                                onChange={(e) => setContrasenaActual(e.target.value)}
                            />
                        </div>

                        <div style={estilos.campo}>
                            <label style={estilos.label}>Nueva contraseña</label>
                            <input
                                style={{
                                    ...estilos.input,
                                    ...(editando ? {} : estilos.inputDeshabilitado)
                                }}
                                type="password"
                                placeholder="Mínimo 8 caracteres"
                                value={nuevaContrasena}
                                disabled={!editando}
                                onChange={(e) => setNuevaContrasena(e.target.value)}
                            />
                        </div>
                    </div>
                </section>

                <div style={estilos.acciones}>
                    {editando && (
                        <>
                            <button
                                type="button"
                                style={estilos.btnCancelar}
                                disabled={guardando}
                                onClick={() => {
                                    setNombre(localStorage.getItem('nombreUsuario') || '');
                                    setCorreo(localStorage.getItem('correoUsuario') || '');
                                    setContrasenaActual('');
                                    setNuevaContrasena('');
                                    setEditando(false);
                                }}
                            >
                                Descartar
                            </button>

                            <button
                                type="button"
                                style={estilos.btnGuardar}
                                disabled={guardando}
                                onClick={guardarCambios}
                            >
                                {guardando ? 'Guardando...' : 'Guardar Cambios'}
                            </button>
                        </>
                    )}
                </div>
            </div>
        </div>
    );
};

const estilos = {
    contenedor: {
        maxWidth: '1050px',
        margin: '0 auto',
        padding: '40px 48px'
    },
    encabezado: {
        marginBottom: '42px'
    },
    subtitulo: {
        color: '#3A5A82',
        fontWeight: 800,
        letterSpacing: '0.14em',
        textTransform: 'uppercase',
        fontSize: '0.75rem',
        marginBottom: '8px'
    },
    titulo: {
        fontSize: '2.6rem',
        fontWeight: 900,
        color: '#2B3437',
        margin: 0
    },
    tituloAzul: {
        color: '#3A5A82'
    },
    descripcion: {
        color: '#586064',
        fontSize: '1.05rem',
        marginTop: '14px',
        maxWidth: '620px',
        lineHeight: 1.6
    },
    grid: {
        display: 'grid',
        gridTemplateColumns: '7fr 5fr',
        gap: '28px'
    },
    cardGrande: {
        backgroundColor: '#FFFFFF',
        borderRadius: '18px',
        padding: '32px',
        boxShadow: '0 18px 45px rgba(63, 95, 146, 0.06)'
    },
    cardChica: {
        backgroundColor: '#FFFFFF',
        borderRadius: '18px',
        padding: '32px',
        boxShadow: '0 18px 45px rgba(63, 95, 146, 0.06)'
    },
    cardHeader: {
        display: 'flex',
        alignItems: 'center',
        gap: '14px',
        marginBottom: '28px'
    },
    iconoCaja: {
        width: '42px',
        height: '42px',
        borderRadius: '14px',
        backgroundColor: '#D6E3FF',
        color: '#3A5A82',
        display: 'flex',
        alignItems: 'center',
        justifyContent: 'center'
    },
    iconoCajaSecundaria: {
        width: '42px',
        height: '42px',
        borderRadius: '14px',
        backgroundColor: '#DCDDFF',
        color: '#5B5D78',
        display: 'flex',
        alignItems: 'center',
        justifyContent: 'center'
    },
    cardTitulo: {
        margin: 0,
        color: '#2B3437',
        fontSize: '1.25rem',
        fontWeight: 800
    },
    formulario: {
        display: 'flex',
        flexDirection: 'column',
        gap: '22px'
    },
    fila: {
        display: 'grid',
        gridTemplateColumns: '1fr 1fr',
        gap: '20px'
    },
    campo: {
        display: 'flex',
        flexDirection: 'column',
        gap: '8px'
    },
    label: {
        fontSize: '0.72rem',
        fontWeight: 800,
        color: '#586064',
        textTransform: 'uppercase',
        letterSpacing: '0.08em'
    },
    input: {
        border: 'none',
        backgroundColor: '#F1F4F6',
        borderRadius: '14px',
        padding: '14px 16px',
        color: '#2B3437',
        fontSize: '0.95rem',
        outline: 'none'
    },
    inputDeshabilitado: {
        opacity: 0.75,
        cursor: 'not-allowed'
    },
    acciones: {
        gridColumn: '1 / -1',
        display: 'flex',
        justifyContent: 'flex-end',
        gap: '14px',
        marginTop: '8px'
    },
    btnEditar: {
        alignSelf: 'flex-start',
        border: 'none',
        backgroundColor: '#3A5A82',
        color: 'white',
        borderRadius: '999px',
        padding: '12px 22px',
        fontWeight: 800,
        cursor: 'pointer'
    },
    btnCancelar: {
        border: 'none',
        backgroundColor: 'transparent',
        color: '#586064',
        borderRadius: '999px',
        padding: '12px 24px',
        fontWeight: 800,
        cursor: 'pointer'
    },
    btnGuardar: {
        border: 'none',
        backgroundColor: '#3A5A82',
        color: 'white',
        borderRadius: '999px',
        padding: '12px 28px',
        fontWeight: 800,
        cursor: 'pointer',
        boxShadow: '0 10px 20px rgba(63, 95, 146, 0.15)'
    }
};

export default MisDatosDashboard;