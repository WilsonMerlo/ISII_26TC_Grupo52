import React, { useMemo, useState } from 'react';
import { usuarioService } from '../services/usuarioService';

const obtenerCorreoGuardado = () => {
    return (
        localStorage.getItem('correoUsuario') ||
        localStorage.getItem('emailUsuario') ||
        localStorage.getItem('correo') ||
        localStorage.getItem('email') ||
        ''
    );
};

const MisDatosDashboard = () => {
    const nombreGuardado = localStorage.getItem('nombreUsuario') || 'Usuario';
    const correoGuardado = obtenerCorreoGuardado();

    const nombreSeparado = useMemo(() => {
        const partes = nombreGuardado.trim().split(/\s+/);

        return {
            nombres: partes.slice(0, 1).join(' ') || nombreGuardado,
            apellidos: partes.slice(1).join(' ')
        };
    }, [nombreGuardado]);

    const [nombres, setNombres] = useState(nombreSeparado.nombres);
    const [apellidos, setApellidos] = useState(nombreSeparado.apellidos);
    const [correo, setCorreo] = useState(correoGuardado);

    const [passwordActual, setPasswordActual] = useState('');
    const [passwordNueva, setPasswordNueva] = useState('');

    const [editandoDatos, setEditandoDatos] = useState(false);
    const [guardandoDatos, setGuardandoDatos] = useState(false);
    const [guardandoPassword, setGuardandoPassword] = useState(false);

    const descartarCambios = () => {
        setNombres(nombreSeparado.nombres);
        setApellidos(nombreSeparado.apellidos);
        setCorreo(correoGuardado);
        setEditandoDatos(false);
    };

    const guardarCambios = async () => {
        try {
            setGuardandoDatos(true);

            const idUsuario = localStorage.getItem('idUsuario');
            const nombreCompleto = `${nombres} ${apellidos}`.trim();

            if (!nombreCompleto) {
                alert('El nombre no puede estar vacío.');
                return;
            }

            if (!correo.trim()) {
                alert('El correo no puede estar vacío.');
                return;
            }

            const usuarioActualizado = await usuarioService.actualizarDatos(
                idUsuario,
                {
                    nombre: nombreCompleto,
                    correo,
                    contrasena: 'sin-cambios'
                }
            );

            localStorage.setItem('nombreUsuario', usuarioActualizado.nombre);
            localStorage.setItem('correoUsuario', usuarioActualizado.correo);
            localStorage.setItem('emailUsuario', usuarioActualizado.correo);

            window.dispatchEvent(new Event('datosUsuarioActualizados'));

            setEditandoDatos(false);

            alert('Datos actualizados correctamente.');
        } catch (error) {
            alert(error.message || 'No se pudieron actualizar los datos.');
        } finally {
            setGuardandoDatos(false);
        }
    };

    const cambiarContrasena = async () => {
        try {
            setGuardandoPassword(true);

            const idUsuario = localStorage.getItem('idUsuario');

            if (!passwordActual.trim()) {
                alert('Ingresá tu contraseña actual.');
                return;
            }

            if (!passwordNueva.trim()) {
                alert('Ingresá una nueva contraseña.');
                return;
            }

            await usuarioService.cambiarContrasena(
                idUsuario,
                passwordActual,
                passwordNueva
            );

            setPasswordActual('');
            setPasswordNueva('');

            alert('Contraseña actualizada correctamente.');
        } catch (error) {
            alert(error.message || 'No se pudo cambiar la contraseña.');
        } finally {
            setGuardandoPassword(false);
        }
    };

    return (
        <div style={estilos.page}>
            <section style={estilos.hero}>
                <p style={estilos.kicker}>Panel de usuario</p>
                <h2 style={estilos.titulo}>
                    Tu espacio, <span style={estilos.tituloAzul}>tus reglas.</span>
                </h2>
                <p style={estilos.descripcion}>
                    Ajusta tus datos personales y la información básica de tu cuenta
                </p>
            </section>

            <div style={estilos.grid}>
                <section style={{ ...estilos.card, ...estilos.cardPrincipal }}>
                    <div style={estilos.cardHeaderConAccion}>
                        <div style={estilos.cardHeader}>
                            <div style={estilos.iconoCard}>👤</div>
                            <h3 style={estilos.cardTitulo}>Datos Personales</h3>
                        </div>

                        <span style={editandoDatos ? estilos.estadoEditando : estilos.estadoLectura}>
                            {editandoDatos ? 'Edición habilitada' : 'Sólo lectura'}
                        </span>
                    </div>

                    <div style={estilos.formGridDos}>
                        <label style={estilos.campo}>
                            <span style={estilos.label}>Nombres</span>
                            <input
                                style={{
                                    ...estilos.input,
                                    ...(!editandoDatos ? estilos.inputDeshabilitado : {})
                                }}
                                value={nombres}
                                onChange={(e) => setNombres(e.target.value)}
                                placeholder="Ej: Alejandro"
                                disabled={!editandoDatos}
                            />
                        </label>

                        <label style={estilos.campo}>
                            <span style={estilos.label}>Apellidos</span>
                            <input
                                style={{
                                    ...estilos.input,
                                    ...(!editandoDatos ? estilos.inputDeshabilitado : {})
                                }}
                                value={apellidos}
                                onChange={(e) => setApellidos(e.target.value)}
                                placeholder="Ej: García"
                                disabled={!editandoDatos}
                            />
                        </label>
                    </div>

                    <label style={estilos.campo}>
                        <span style={estilos.label}>Correo Electrónico</span>
                        <input
                            style={{
                                ...estilos.input,
                                ...(!editandoDatos ? estilos.inputDeshabilitado : {})
                            }}
                            value={correo}
                            onChange={(e) => setCorreo(e.target.value)}
                            type="email"
                            placeholder="usuario@correo.com"
                            disabled={!editandoDatos}
                        />
                    </label>

                    <div style={estilos.accionesDatosPersonales}>
                        {!editandoDatos ? (
                            <button
                                type="button"
                                style={estilos.btnEditarDatos}
                                onClick={() => setEditandoDatos(true)}
                            >
                                Habilitar edición
                            </button>
                        ) : (
                            <>
                                <button
                                    type="button"
                                    style={estilos.btnDescartarDatos}
                                    onClick={descartarCambios}
                                    disabled={guardandoDatos}
                                >
                                    Cancelar edición
                                </button>

                                <button
                                    type="button"
                                    style={estilos.btnGuardarDatos}
                                    onClick={guardarCambios}
                                    disabled={guardandoDatos}
                                >
                                    {guardandoDatos ? 'Guardando...' : 'Guardar datos'}
                                </button>
                            </>
                        )}
                    </div>
                </section>

                <section style={estilos.card}>
                    <div style={estilos.cardHeader}>
                        <div style={estilos.iconoCardSecundario}>🔒</div>
                        <h3 style={estilos.cardTitulo}>Cambiar contraseña</h3>
                    </div>

                    <label style={estilos.campo}>
                        <span style={estilos.label}>Contraseña actual</span>
                        <input
                            style={estilos.input}
                            value={passwordActual}
                            onChange={(e) => setPasswordActual(e.target.value)}
                            type="password"
                            placeholder="••••••••"
                        />
                    </label>

                    <label style={estilos.campo}>
                        <span style={estilos.label}>Nueva contraseña</span>
                        <input
                            style={estilos.input}
                            value={passwordNueva}
                            onChange={(e) => setPasswordNueva(e.target.value)}
                            type="password"
                            placeholder="••••••••"
                        />
                    </label>

                    <div style={estilos.accionesPassword}>
                        <button
                            type="button"
                            style={estilos.btnGuardarPassword}
                            onClick={cambiarContrasena}
                            disabled={guardandoPassword}
                        >
                            {guardandoPassword ? 'Guardando...' : 'Cambiar contraseña'}
                        </button>
                    </div>
                </section>
            </div>
        </div>
    );
};

const estilos = {
    page: {
        flex: 1,
        overflowY: 'auto',
        padding: '46px 56px 64px',
        backgroundColor: '#F6F8FE',
        fontFamily: "'IBM Plex Sans', 'Helvetica Neue', sans-serif"
    },
    hero: {
        marginBottom: '38px'
    },
    kicker: {
        color: '#3A56AF',
        fontWeight: 800,
        letterSpacing: '0.14em',
        textTransform: 'uppercase',
        fontSize: '0.75rem',
        margin: '0 0 10px'
    },
    titulo: {
        margin: 0,
        color: '#2D3247',
        fontSize: '2.6rem',
        lineHeight: 1.1,
        fontWeight: 900,
        letterSpacing: '-0.04em'
    },
    tituloAzul: {
        color: '#3A56AF'
    },
    descripcion: {
        color: '#6A7185',
        fontSize: '1.05rem',
        maxWidth: '620px',
        lineHeight: 1.6,
        margin: '16px 0 0'
    },
    grid: {
        display: 'grid',
        gridTemplateColumns: 'minmax(0, 7fr) minmax(320px, 5fr)',
        gap: '26px',
        maxWidth: '1060px'
    },
    card: {
        backgroundColor: 'white',
        borderRadius: '18px',
        padding: '30px',
        border: '1px solid #E8EBFF',
        boxShadow: '0 16px 34px rgba(58, 86, 175, 0.06)',
        display: 'flex',
        flexDirection: 'column',
        gap: '22px'
    },
    cardPrincipal: {
        minHeight: '300px'
    },
    cardHeaderConAccion: {
        display: 'flex',
        justifyContent: 'space-between',
        alignItems: 'center',
        gap: '16px',
        marginBottom: '4px'
    },
    cardHeader: {
        display: 'flex',
        alignItems: 'center',
        gap: '12px',
        marginBottom: '4px'
    },
    iconoCard: {
        width: '42px',
        height: '42px',
        borderRadius: '50%',
        backgroundColor: '#DDE6FF',
        display: 'flex',
        alignItems: 'center',
        justifyContent: 'center'
    },
    iconoCardSecundario: {
        width: '42px',
        height: '42px',
        borderRadius: '50%',
        backgroundColor: '#ECECFF',
        display: 'flex',
        alignItems: 'center',
        justifyContent: 'center'
    },
    cardTitulo: {
        margin: 0,
        color: '#2D3247',
        fontSize: '1.25rem',
        fontWeight: 800
    },
    estadoLectura: {
        backgroundColor: '#F1F4F6',
        color: '#8E96AE',
        borderRadius: '999px',
        padding: '7px 11px',
        fontSize: '0.7rem',
        fontWeight: 900,
        textTransform: 'uppercase',
        letterSpacing: '0.06em',
        whiteSpace: 'nowrap'
    },
    estadoEditando: {
        backgroundColor: '#DDE6FF',
        color: '#3A56AF',
        borderRadius: '999px',
        padding: '7px 11px',
        fontSize: '0.7rem',
        fontWeight: 900,
        textTransform: 'uppercase',
        letterSpacing: '0.06em',
        whiteSpace: 'nowrap'
    },
    formGridDos: {
        display: 'grid',
        gridTemplateColumns: 'repeat(2, minmax(0, 1fr))',
        gap: '18px'
    },
    campo: {
        display: 'flex',
        flexDirection: 'column',
        gap: '8px'
    },
    label: {
        color: '#6A7185',
        fontSize: '0.72rem',
        fontWeight: 800,
        textTransform: 'uppercase',
        letterSpacing: '0.08em'
    },
    input: {
        width: '100%',
        border: 'none',
        outline: 'none',
        backgroundColor: '#F1F4F6',
        color: '#2D3247',
        borderRadius: '12px',
        padding: '14px 16px',
        fontSize: '0.95rem',
        fontFamily: 'inherit'
    },
    inputDeshabilitado: {
        backgroundColor: '#F8FAFF',
        color: '#5E667A',
        cursor: 'not-allowed',
        opacity: 0.9
    },
    accionesDatosPersonales: {
        display: 'flex',
        justifyContent: 'flex-end',
        alignItems: 'center',
        gap: '12px',
        paddingTop: '4px',
        marginTop: 'auto'
    },
    accionesPassword: {
        display: 'flex',
        justifyContent: 'flex-end',
        marginTop: 'auto'
    },
    btnEditarDatos: {
        border: 'none',
        backgroundColor: '#3A56AF',
        color: 'white',
        borderRadius: '999px',
        padding: '12px 20px',
        fontWeight: 900,
        cursor: 'pointer',
        fontFamily: 'inherit',
        boxShadow: '0 12px 22px rgba(58, 86, 175, 0.18)'
    },
    btnDescartarDatos: {
        border: '1px solid #E8EBFF',
        backgroundColor: 'white',
        color: '#6A7185',
        borderRadius: '999px',
        padding: '11px 18px',
        fontWeight: 800,
        cursor: 'pointer',
        fontFamily: 'inherit'
    },
    btnGuardarDatos: {
        border: 'none',
        backgroundColor: '#3A56AF',
        color: 'white',
        borderRadius: '999px',
        padding: '12px 20px',
        fontWeight: 900,
        cursor: 'pointer',
        fontFamily: 'inherit'
    },
    btnGuardarPassword: {
        border: 'none',
        background: 'linear-gradient(135deg, #3A56AF 0%, #2F478F 100%)',
        color: 'white',
        padding: '13px 24px',
        borderRadius: '999px',
        fontWeight: 900,
        cursor: 'pointer',
        fontFamily: 'inherit',
        boxShadow: '0 14px 26px rgba(58, 86, 175, 0.18)'
    }
};

export default MisDatosDashboard;