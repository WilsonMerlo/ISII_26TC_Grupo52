import React, { useState } from 'react';

const RecuperarPassword = ({ onNavegar }) => {
    const [email, setEmail] = useState('');
    const [enviado, setEnviado] = useState(false);

    const manejarEnvio = (e) => {
        e.preventDefault();
        if (!email.includes('@')) {
            alert("Por favor, ingresa un correo válido.");
            return;
        }
        // Simulamos la llamada a la API
        setEnviado(true);
    };

    return (
        <div style={estilos.fullPageWrap}>
            {/* Logo superior fuera de la tarjeta */}
            <h1 style={estilos.logoTop}>Sanctuary</h1>

            <main style={estilos.mainContentArea}>
                <form style={estilos.card} onSubmit={manejarEnvio}>
                    {/* Ícono superior (Cuadrado celeste con flecha) */}
                    <div style={estilos.iconWrap}>
                        <span style={estilos.icon}>↺</span>
                    </div>

                    <h2 style={estilos.formTitle}>Recuperar contraseña</h2>
                    <p style={estilos.formSubtitle}>
                        Introduce tu correo electrónico y te enviaremos un enlace seguro para restablecer tu acceso.
                    </p>

                    {enviado ? (
                        <div style={estilos.successMsg}>
                            ¡Instrucciones enviadas! Revisa tu bandeja de entrada.
                        </div>
                    ) : (
                        <>
                            <div style={estilos.inputGroup}>
                                <label style={estilos.inputLabel}>EMAIL</label>
                                <input 
                                    type="email" 
                                    value={email} 
                                    onChange={(e) => setEmail(e.target.value)}
                                    placeholder="ejemplo@sanctuary.com"
                                    style={estilos.textInput}
                                    required
                                />
                            </div>

                            <button type="submit" style={estilos.mainBtn}>
                                Enviar Instrucciones
                            </button>
                        </>
                    )}

                    <button 
                        type="button" 
                        style={estilos.backLinkBtn} 
                        onClick={() => onNavegar('login')}
                    >
                        ← Volver al Inicio de Sesión
                    </button>
                </form>
            </main>

            <footer style={estilos.footer}>
                © 2026 Sanctuary Sanctuary. Diseñado para Deep Work. • Privacy Policy • Terms of Service • Help Center
            </footer>
        </div>
    );
};

const estilos = {
    fullPageWrap: { fontFamily: "'Inter', sans-serif", backgroundColor: '#F6F8FE', minHeight: '100vh', display: 'flex', flexDirection: 'column', alignItems: 'center', padding: '40px 20px' },
    logoTop: { fontSize: '1.8rem', fontWeight: '700', color: '#3A56AF', margin: '0 0 20px 0' },
    mainContentArea: { flex: 1, display: 'flex', justifyContent: 'center', alignItems: 'center', width: '100%' },
    card: { backgroundColor: 'white', padding: '50px', borderRadius: '15px', border: '1px solid #E8EBFF', boxShadow: '0 4px 20px rgba(0,0,0,0.03)', width: '100%', maxWidth: '450px', textAlign: 'center', display: 'flex', flexDirection: 'column', alignItems: 'center' },
    
    iconWrap: { width: '60px', height: '60px', backgroundColor: '#E8EBFF', borderRadius: '12px', display: 'flex', justifyContent: 'center', alignItems: 'center', marginBottom: '20px' },
    icon: { fontSize: '1.5rem', color: '#3A56AF', fontWeight: 'bold' },
    
    formTitle: { fontSize: '2rem', fontWeight: '800', color: '#2D3247', margin: '0 0 10px 0' },
    formSubtitle: { fontSize: '1rem', color: '#9EA5BA', fontWeight: '500', margin: '0 0 30px 0', lineHeight: '1.5' },
    
    inputGroup: { width: '100%', textAlign: 'left', marginBottom: '25px' },
    inputLabel: { display: 'block', fontSize: '0.8rem', color: '#9EA5BA', fontWeight: '700', letterSpacing: '1px', marginBottom: '8px' },
    textInput: { width: '100%', padding: '15px', borderRadius: '10px', border: '1px solid #E8EBFF', backgroundColor: '#F9FBFF', fontSize: '1rem', color: '#2D3247', outline: 'none', boxSizing: 'border-box' },
    
    mainBtn: { width: '100%', backgroundColor: '#3A56AF', color: 'white', border: 'none', borderRadius: '10px', padding: '15px', fontSize: '1.1rem', fontWeight: '700', cursor: 'pointer', marginBottom: '20px' },
    backLinkBtn: { background: 'none', border: 'none', color: '#3A56AF', fontWeight: '600', fontSize: '1rem', cursor: 'pointer' },
    successMsg: { color: '#3A56AF', backgroundColor: '#E8EBFF', padding: '15px', borderRadius: '8px', fontWeight: '600', marginBottom: '20px', width: '100%' },
    footer: { fontSize: '0.8rem', color: '#9EA5BA', fontWeight: '500', opacity: 0.6, marginTop: 'auto' }
};

export default RecuperarPassword;