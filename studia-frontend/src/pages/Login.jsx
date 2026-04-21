import React, { useState } from 'react';

const Login = ({ onNavegar }) => {
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [recordarme, setRecordarme] = useState(false);
    const [error, setError] = useState(null);

    const manejarEnvio = async (e) => {
        e.preventDefault();
        setError(null);

        const credenciales = {
            correo: email,
            contrasena: password
        };

        try {
            console.log("1. Enviando datos al servidor:", credenciales);

            const response = await fetch("https://localhost:7068/api/Usuarios/login", {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify(credenciales)
            });

            console.log("2. El servidor respondió con status:", response.status);

            if (response.ok) {
                const textoRespuesta = await response.text();
                console.log("3. Datos crudos:", textoRespuesta);

                const usuarioLogueado = JSON.parse(textoRespuesta);

                localStorage.setItem('idUsuario', usuarioLogueado.idUsuario);
                localStorage.setItem('nombreUsuario', usuarioLogueado.nombre);

                alert(`¡Hola ${usuarioLogueado.nombre}! Entrando a StudIA...`);
                onNavegar('dashboard');

            } else if (response.status === 401) {
                setError("Correo o contraseña incorrectos.");
            } else {
                setError(`Error del servidor: ${response.status}`);
            }
        } catch (err) {
            console.error("🚨 EL VERDADERO ERROR ES:", err);
            setError(`Falla técnica: ${err.message}`);
        }
    };

    return (
        <>
            <style>{`
                @import url('https://fonts.googleapis.com/css2?family=IBM+Plex+Sans:ital,wght@0,400;0,500;0,600;0,700;1,400&display=swap');

                * { box-sizing: border-box; margin: 0; padding: 0; }

                .login-root {
                    font-family: 'IBM Plex Sans', 'Helvetica Neue', sans-serif;
                    display: flex;
                    min-height: 100vh;
                    width: 100%;
                    background-color: #F6F8FE;
                }

                /* ── PANEL IZQUIERDO ── */
                .login-left {
                    width: 42%;
                    min-height: 100vh;
                    background-color: #2D3247;
                    display: flex;
                    flex-direction: column;
                    justify-content: space-between;
                    padding: 48px 56px;
                    position: relative;
                    overflow: hidden;
                    flex-shrink: 0;
                }

                .login-left::before {
                    content: '';
                    position: absolute;
                    top: -80px;
                    right: -80px;
                    width: 340px;
                    height: 340px;
                    border-radius: 50%;
                    border: 90px solid rgba(58, 86, 175, 0.15);
                    pointer-events: none;
                }
                .login-left::after {
                    content: '';
                    position: absolute;
                    bottom: -100px;
                    left: -100px;
                    width: 400px;
                    height: 400px;
                    border-radius: 50%;
                    border: 90px solid rgba(58, 86, 175, 0.1);
                    pointer-events: none;
                }

                .left-top { position: relative; z-index: 1; }

                .left-logo-row {
                    display: flex;
                    align-items: center;
                    gap: 12px;
                    margin-bottom: 6px;
                }
                .left-logo-icon {
                    width: 40px;
                    height: 40px;
                    border-radius: 6px;
                    background-color: #3A56AF;
                    color: white;
                    display: flex;
                    align-items: center;
                    justify-content: center;
                    font-weight: 700;
                    font-size: 1.3rem;
                    flex-shrink: 0;
                }
                .left-logo-name {
                    font-size: 1.6rem;
                    font-weight: 700;
                    color: #FFFFFF;
                    letter-spacing: -0.02em;
                }
                .left-logo-subtitle {
                    font-size: 0.78rem;
                    color: #6B7591;
                    letter-spacing: 0.02em;
                    padding-left: 52px;
                }

                .left-middle {
                    position: relative;
                    z-index: 1;
                    flex: 1;
                    display: flex;
                    flex-direction: column;
                    justify-content: center;
                    padding: 48px 0;
                }
                .left-accent-line {
                    width: 36px;
                    height: 3px;
                    background-color: #3A56AF;
                    margin-bottom: 24px;
                    border-radius: 2px;
                }
                .left-headline {
                    font-size: 1.85rem;
                    font-weight: 700;
                    color: #FFFFFF;
                    line-height: 1.3;
                    letter-spacing: -0.03em;
                    margin-bottom: 16px;
                }
                .left-headline span { color: #6B87D4; }
                .left-body {
                    font-size: 0.88rem;
                    color: #6B7591;
                    line-height: 1.75;
                    max-width: 320px;
                }

                .left-bottom {
                    position: relative;
                    z-index: 1;
                    border-top: 1px solid rgba(255,255,255,0.06);
                    padding-top: 28px;
                }
                .left-quote-mark {
                    font-family: Georgia, serif;
                    font-size: 3rem;
                    color: #3A56AF;
                    line-height: 1;
                    margin-bottom: 8px;
                }
                .left-quote-text {
                    font-style: italic;
                    font-size: 0.87rem;
                    color: #6B7591;
                    line-height: 1.7;
                    margin-bottom: 10px;
                }
                .left-quote-source {
                    font-size: 0.68rem;
                    color: #4A5270;
                    font-weight: 700;
                    letter-spacing: 0.1em;
                    text-transform: uppercase;
                }

                /* ── PANEL DERECHO ── */
                .login-right {
                    flex: 1;
                    display: flex;
                    flex-direction: column;
                    justify-content: center;
                    align-items: center;
                    padding: 48px 40px;
                    min-height: 100vh;
                    background-color: #F6F8FE;
                }

                .login-form-wrap {
                    width: 100%;
                    max-width: 440px;
                }

                .form-header { margin-bottom: 36px; }
                .form-title {
                    font-size: 1.85rem;
                    font-weight: 700;
                    color: #2D3247;
                    letter-spacing: -0.03em;
                    margin-bottom: 8px;
                }
                .form-subtitle {
                    font-size: 0.9rem;
                    color: #9EA5BA;
                }

                /* Error */
                .error-box {
                    display: flex;
                    align-items: center;
                    gap: 10px;
                    background-color: #FFF2F2;
                    border: 1px solid #FFCDD2;
                    border-radius: 6px;
                    padding: 11px 14px;
                    margin-bottom: 20px;
                }
                .error-box svg { flex-shrink: 0; color: #C0392B; }
                .error-box p { color: #C0392B; font-weight: 500; font-size: 0.87rem; }

                /* Inputs */
                .input-group { margin-bottom: 18px; }
                .input-label {
                    display: block;
                    font-size: 0.7rem;
                    color: #9EA5BA;
                    font-weight: 700;
                    letter-spacing: 0.08em;
                    text-transform: uppercase;
                    margin-bottom: 8px;
                }
                .input-wrap { position: relative; }
                .input-icon {
                    position: absolute;
                    top: 50%;
                    left: 14px;
                    transform: translateY(-50%);
                    color: #B0B7CF;
                    display: flex;
                    align-items: center;
                    pointer-events: none;
                }
                .text-input {
                    width: 100%;
                    padding: 13px 14px 13px 42px;
                    border-radius: 6px;
                    border: 1px solid #E0E4F4;
                    background-color: #FFFFFF;
                    font-size: 0.93rem;
                    font-family: 'IBM Plex Sans', sans-serif;
                    color: #2D3247;
                    outline: none;
                    transition: border-color 0.15s, box-shadow 0.15s;
                }
                .text-input:focus {
                    border-color: #3A56AF;
                    box-shadow: 0 0 0 3px rgba(58, 86, 175, 0.1);
                }
                .text-input::placeholder { color: #C8CEDE; }

                /* Fila adicional */
                .fila-adicional {
                    display: flex;
                    justify-content: flex-end;
                    margin-bottom: 28px;
                }
                .olvide-btn {
                    font-size: 0.84rem;
                    color: #3A56AF;
                    font-weight: 500;
                    background: none;
                    border: none;
                    padding: 0;
                    cursor: pointer;
                    font-family: inherit;
                }
                .olvide-btn:hover { text-decoration: underline; }

                /* Botón principal */
                .submit-btn {
                    width: 100%;
                    background-color: #3A56AF;
                    color: white;
                    border: none;
                    border-radius: 6px;
                    padding: 14px;
                    font-size: 0.95rem;
                    font-weight: 600;
                    font-family: inherit;
                    cursor: pointer;
                    letter-spacing: 0.01em;
                    box-shadow: 0 2px 8px rgba(58, 86, 175, 0.28);
                    display: flex;
                    justify-content: center;
                    align-items: center;
                    gap: 8px;
                    transition: background-color 0.15s, box-shadow 0.15s;
                }
                .submit-btn:hover {
                    background-color: #2F469A;
                    box-shadow: 0 4px 14px rgba(58, 86, 175, 0.36);
                }

                /* Registrarse */
                .registro-seccion {
                    margin-top: 28px;
                    display: flex;
                    align-items: center;
                    justify-content: center;
                    gap: 6px;
                }
                .registro-texto {
                    font-size: 0.88rem;
                    color: #9EA5BA;
                }
                .registro-btn {
                    font-size: 0.88rem;
                    color: #3A56AF;
                    font-weight: 600;
                    background: none;
                    border: none;
                    padding: 0;
                    cursor: pointer;
                    font-family: inherit;
                }
                .registro-btn:hover { text-decoration: underline; }

                /* Footer derecho */
                .right-footer {
                    margin-top: 48px;
                    text-align: center;
                }
                .right-footer p {
                    font-size: 0.73rem;
                    color: #C0C6D8;
                    line-height: 1.6;
                }

                /* ── RESPONSIVE ── */
                @media (max-width: 860px) {
                    .login-left { display: none; }
                    .login-right { padding: 40px 24px; }
                    .login-form-wrap { max-width: 100%; }
                }
            `}</style>

            <div className="login-root">

                {/* ── PANEL IZQUIERDO ── */}
                <aside className="login-left">
                    <div className="left-top">
                        <div className="left-logo-row">
                            <span className="left-logo-icon">S</span>
                            <h1 className="left-logo-name">StudIA</h1>
                        </div>
                        <p className="left-logo-subtitle">Tu espacio para el trabajo profundo</p>
                    </div>

                    <div className="left-middle">
                        <div className="left-accent-line" />
                        <h2 className="left-headline">
                            Estudia más inteligente,<br />
                            no más <span>duro</span>.
                        </h2>
                        <p className="left-body">
                            Pomodoros, apuntes inteligentes y seguimiento de progreso,
                            todo en un solo lugar diseñado para el enfoque profundo.
                        </p>
                    </div>

                    <div className="left-bottom">
                        <div className="left-quote-mark">"</div>
                        <p className="left-quote-text">
                            La profundidad de tu enfoque determina el nivel de tu maestría.
                        </p>
                        <div className="left-quote-source">Filosofía StudIA</div>
                    </div>
                </aside>

                {/* ── PANEL DERECHO ── */}
                <section className="login-right">
                    <div className="login-form-wrap">
                        <div className="form-header">
                            <h2 className="form-title">Iniciar Sesión</h2>
                            <p className="form-subtitle">Ingresa tus credenciales para continuar</p>
                        </div>

                        {error && (
                            <div className="error-box">
                                <svg viewBox="0 0 20 20" fill="currentColor" width="16" height="16">
                                    <path fillRule="evenodd" d="M18 10a8 8 0 11-16 0 8 8 0 0116 0zm-7 4a1 1 0 11-2 0 1 1 0 012 0zm-1-9a1 1 0 00-1 1v4a1 1 0 102 0V6a1 1 0 00-1-1z" clipRule="evenodd" />
                                </svg>
                                <p>{error}</p>
                            </div>
                        )}

                        <form onSubmit={manejarEnvio}>
                            <div className="input-group">
                                <label className="input-label">Correo Electrónico</label>
                                <div className="input-wrap">
                                    <span className="input-icon">
                                        <svg viewBox="0 0 20 20" fill="none" stroke="currentColor" strokeWidth="1.5" width="15" height="15">
                                            <path strokeLinecap="round" strokeLinejoin="round" d="M2.5 5.5A1.5 1.5 0 014 4h12a1.5 1.5 0 011.5 1.5v9A1.5 1.5 0 0116 16H4a1.5 1.5 0 01-1.5-1.5v-9z" />
                                            <path strokeLinecap="round" strokeLinejoin="round" d="M2.5 6l7.5 5 7.5-5" />
                                        </svg>
                                    </span>
                                    <input
                                        type="email"
                                        value={email}
                                        onChange={(e) => setEmail(e.target.value)}
                                        placeholder="nombre@ejemplo.com"
                                        className="text-input"
                                        required
                                    />
                                </div>
                            </div>

                            <div className="input-group">
                                <label className="input-label">Contraseña</label>
                                <div className="input-wrap">
                                    <span className="input-icon">
                                        <svg viewBox="0 0 20 20" fill="none" stroke="currentColor" strokeWidth="1.5" width="15" height="15">
                                            <rect x="4" y="9" width="12" height="9" rx="1.5" strokeLinecap="round" strokeLinejoin="round" />
                                            <path strokeLinecap="round" strokeLinejoin="round" d="M7 9V6.5a3 3 0 016 0V9" />
                                            <circle cx="10" cy="13.5" r="1" fill="currentColor" stroke="none" />
                                        </svg>
                                    </span>
                                    <input
                                        type="password"
                                        value={password}
                                        onChange={(e) => setPassword(e.target.value)}
                                        placeholder="••••••••"
                                        className="text-input"
                                        required
                                    />
                                </div>
                            </div>

                            <div className="fila-adicional">
                                <button
                                    type="button"
                                    className="olvide-btn"
                                    onClick={() => onNavegar('recuperar')}
                                >
                                    ¿Olvidaste tu contraseña?
                                </button>
                            </div>

                            <button type="submit" className="submit-btn">
                                Iniciar Sesión
                                <svg viewBox="0 0 20 20" fill="currentColor" width="16" height="16">
                                    <path fillRule="evenodd" d="M10.293 3.293a1 1 0 011.414 0l6 6a1 1 0 010 1.414l-6 6a1 1 0 01-1.414-1.414L14.586 11H3a1 1 0 110-2h11.586l-4.293-4.293a1 1 0 010-1.414z" clipRule="evenodd" />
                                </svg>
                            </button>
                        </form>

                        <div className="registro-seccion">
                            <p className="registro-texto">¿No tienes una cuenta?</p>
                            <button
                                type="button"
                                className="registro-btn"
                                onClick={() => onNavegar('registro')}
                            >
                                Registrarse
                            </button>
                        </div>

                        <div className="right-footer">
                            <p>© 2026 StudIA. Diseñado para Deep Work. · Política de Privacidad · Términos de Servicio</p>
                        </div>
                    </div>
                </section>

            </div>
        </>
    );
};

export default Login;
