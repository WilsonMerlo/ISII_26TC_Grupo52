import React, { useState } from 'react';

const Login = () => {
    // --- ESTADOS ---
    const [email, setEmail] = useState(''); // Email del usuario
    const [password, setPassword] = useState(''); // Contraseña
    const [recordarme, setRecordarme] = useState(false); // Checkbox de "Recordarme"
    const [error, setError] = useState(null); // Mensajes de error

    // --- MANEJO DE ENVÍO DE FORMULARIO ---
    const manejarEnvio = (e) => {
        e.preventDefault(); // Evitamos que la página se recargue
        setError(null); // Limpiamos errores anteriores

        // --- VALIDACIÓN BÁSICA ---
        if (!email.includes('@')) {
            setError("Por favor, introduce un correo electrónico válido.");
            return;
        }
        if (password.length < 6) {
            setError("La contraseña debe tener al menos 6 caracteres.");
            return;
        }

        // --- SIMULACIÓN DE LOGIN ---
        console.log("Iniciando sesión con:", { email, password, recordarme });
        alert(`¡Login simulado con éxito para ${email}!`);
        // Aquí iría la llamada real a tu API
    };

    return (
        <div style={estilos.fullPageWrap}>
            {/* Barra superior minimalista - Spec-Perfect */}
            <header style={estilos.loginTopBar}>
                <div style={estilos.logoSeccion}>
                    <span style={estilos.logoIcono}>S</span>
                    <h1 style={estilos.logoNombre}>Sanctuary</h1>
                    <p style={estilos.logoSubtitulo}>Tu espacio para el trabajo profundo</p>
                </div>
            </header>

            {/* Contenido Central (Tarjeta de Login) - Spec-Perfect */}
            <main style={estilos.mainContentArea}>
                <form style={estilos.loginFormCard} onSubmit={manejarEnvio}>
                    <h2 style={estilos.formTitle}>Iniciar Sesión</h2>
                    <p style={estilos.formSubtitle}>Ingresa tus credenciales para continuar</p>

                    {error && <p style={estilos.errorMsg}>{error}</p>}

                    {/* CAMPO: Correo Electrónico */}
                    <div style={estilos.inputGroup}>
                        <label style={estilos.inputLabel}>CORREO ELECTRÓNICO</label>
                        <div style={estilos.inputIconWrap}>
                            <span style={estilos.inputIcon}>✉️</span>
                            <input 
                                type="email" 
                                value={email} 
                                onChange={(e) => setEmail(e.target.value)}
                                placeholder="nombre@ejemplo.com"
                                style={estilos.textInput}
                                required
                            />
                        </div>
                    </div>

                    {/* CAMPO: Contraseña */}
                    <div style={estilos.inputGroup}>
                        <label style={estilos.inputLabel}>CONTRASEÑA</label>
                        <div style={estilos.inputIconWrap}>
                            <span style={estilos.inputIcon}>🔒</span>
                            <input 
                                type="password" 
                                value={password} 
                                onChange={(e) => setPassword(e.target.value)}
                                placeholder="........"
                                style={estilos.textInput}
                                required
                            />
                        </div>
                    </div>

                    {/* FILA: Recordarme + Olvidaste contraseña? */}
                    <div style={estilos.filaAdicional}>
                        <label style={estilos.checkboxLabel}>
                            <input 
                                type="checkbox" 
                                checked={recordarme} 
                                onChange={(e) => setRecordarme(e.target.checked)}
                                style={estilos.checkbox}
                            />
                            Recordarme
                        </label>
                        <a href="#" style={estilos.olvidasteLink}>¿Olvidaste tu contraseña?</a>
                    </div>

                    {/* BOTÓN: Iniciar Sesión */}
                    <button type="submit" style={estilos.mainLoginBtn}>
                        Iniciar Sesión
                        <span style={estilos.btnIcon}>→</span>
                    </button>

                    {/* LINK: Registrarse */}
                    <div style={estilos.registrarseSeccion}>
                        <p style={estilos.registrarseText}>¿No tienes una cuenta?</p>
                        <a href="#" style={estilos.registrarseLink}>Registrarse</a>
                    </div>
                </form>
            </main>
            
            {/* Footer motivacional del login - Spec-Perfect */}
            <footer style={estilos.loginFooter}>
                <div style={estilos.citaFooterSeccion}>
                    <div style={estilos.citaMarksFooter}>⁹⁹</div>
                    <p style={estilos.citaTextFooter}>
                        “La profundidad de tu enfoque determina el nivel de tu maestría.”
                    </p>
                    <div style={estilos.citaSourceFooter}>FILOSOFÍA SANCTUARY</div>
                </div>
                
                <p style={estilos.creditosFooter}>
                    © 2026 Sanctuary Sanctuary. Diseñado para Deep Work. • Política de Privacidad • Términos de Servicio • Centro de Ayuda
                </p>
            </footer>
        </div>
    );
};

// --- ESTILOS CSS REVISADOS (Perfectamente Spec-Perfect para Sanctuary Login) ---
const estilos = {
    fullPageWrap: { fontFamily: "'Inter', sans-serif", backgroundColor: '#F6F8FE', minHeight: '100vh', display: 'flex', flexDirection: 'column', alignItems: 'center', padding: '0' },
    
    // Barra superior
    loginTopBar: { height: '100px', width: '100%', backgroundColor: 'transparent', display: 'flex', alignItems: 'center', justifyContent: 'center', position: 'sticky', top: 0, zIndex: 100 },
    logoSeccion: { display: 'flex', flexDirection: 'column', alignItems: 'center', gap: '5px' },
    logoIcono: { width: '40px', height: '40px', borderRadius: '8px', backgroundColor: '#3A56AF', color: 'white', display: 'flex', justifyContent: 'center', alignItems: 'center', fontWeight: 'bold', fontSize: '1.5rem' },
    logoNombre: { fontSize: '1.6rem', fontWeight: '700', color: '#2D3247', margin: 0 },
    logoSubtitulo: { fontSize: '0.9rem', color: '#9EA5BA', fontWeight: '500', margin: '0 0 0 0' },
    
    // Contenido Central
    mainContentArea: { flex: 1, display: 'flex', justifyContent: 'center', alignItems: 'center', padding: '40px 20px', overflowY: 'auto' },
    loginFormCard: { backgroundColor: 'white', padding: '60px 50px', borderRadius: '15px', border: '1px solid #E8EBFF', boxShadow: '0 4px 20px rgba(0,0,0,0.03)', width: '100%', maxWidth: '500px', textAlign: 'left' },
    formTitle: { fontSize: '2.5rem', fontWeight: '800', color: '#2D3247', margin: '0 0 10px 0' },
    formSubtitle: { fontSize: '1.1rem', color: '#9EA5BA', fontWeight: '500', margin: '0 0 40px 0' },
    errorMsg: { color: 'red', fontWeight: '600', marginBottom: '15px', fontSize: '0.9rem' },
    
    // Inputs
    inputGroup: { marginBottom: '20px' },
    inputLabel: { display: 'block', fontSize: '0.8rem', color: '#9EA5BA', fontWeight: '700', letterSpacing: '1px', marginBottom: '8px' },
    inputIconWrap: { position: 'relative' },
    inputIcon: { position: 'absolute', top: '50%', left: '15px', transform: 'translateY(-50%)', color: '#9EA5BA', fontSize: '1.1rem', opacity: 0.6 },
    textInput: { width: '100%', padding: '15px 15px 15px 45px', borderRadius: '10px', border: '1px solid #E8EBFF', backgroundColor: '#F9FBFF', fontSize: '1rem', color: '#2D3247', outline: 'none' },
    
    // Fila Adicional
    filaAdicional: { display: 'flex', alignItems: 'center', justifyContent: 'space-between', marginBottom: '40px' },
    checkboxLabel: { fontSize: '0.9rem', color: '#9EA5BA', fontWeight: '500', display: 'flex', alignItems: 'center', gap: '8px', cursor: 'pointer' },
    checkbox: { cursor: 'pointer', accentColor: '#3A56AF' },
    olvidasteLink: { fontSize: '0.9rem', color: '#3A56AF', fontWeight: '600', textDecoration: 'none' },
    
    // Botón Principal
    mainLoginBtn: { width: '100%', backgroundColor: '#3A56AF', color: 'white', border: 'none', borderRadius: '10px', padding: '15px', fontSize: '1.1rem', fontWeight: '700', cursor: 'pointer', boxShadow: '0 4px 10px rgba(58, 86, 175, 0.3)', display: 'flex', justifyContent: 'center', alignItems: 'center', gap: '10px' },
    btnIcon: { fontSize: '1.2rem', fontWeight: 'bold' },
    
    // Registrarse
    registrarseSeccion: { marginTop: '40px', textAlign: 'center' },
    registrarseText: { fontSize: '1rem', color: '#9EA5BA', fontWeight: '500', margin: '0 0 5px 0' },
    registrarseLink: { fontSize: '1rem', color: '#3A56AF', fontWeight: '700', textDecoration: 'none' },
    
    // Footer
    loginFooter: { textAlign: 'center', maxWidth: '600px', marginTop: 'auto', padding: '40px 20px', display: 'flex', flexDirection: 'column', gap: '30px' },
    citaFooterSeccion: { color: '#9EA5BA' },
    citaMarksFooter: { fontSize: '2rem', marginBottom: '5px' },
    citaTextFooter: { fontStyle: 'italic', fontSize: '1rem', lineHeight: '1.6', margin: '0 0 8px 0' },
    citaSourceFooter: { fontSize: '0.75rem', color: '#9EA5BA', fontWeight: '700', letterSpacing: '1px', opacity: 0.6 },
    creditosFooter: { fontSize: '0.8rem', color: '#9EA5BA', fontWeight: '500', opacity: 0.6 }
};

export default Login;