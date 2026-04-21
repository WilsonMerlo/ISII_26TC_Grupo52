import React, { useState } from 'react';

const Registro = ({ onNavegar }) => {
    const [formData, setFormData] = useState({ nombre: '', email: '', password: '', confirmPassword: '' });
    const [error, setError] = useState(null);

    const manejarCambio = (e) => {
        setFormData({ ...formData, [e.target.name]: e.target.value });
    };

    const manejarEnvio = async (e) => {
        e.preventDefault();
        setError(null);

        // 1. Validación de contraseñas
        if (formData.password !== formData.confirmPassword) {
            setError("Las contraseñas no coinciden.");
            return;
        }

        // 2. Contrato de Datos para la API
        const nuevoUsuario = {
            nombre: formData.nombre,
            correo: formData.email,
            contrasena: formData.password
        };

        try {
            const response = await fetch("https://localhost:7068/api/Usuarios", {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify(nuevoUsuario)
            });

            if (response.ok) {
                alert("¡Cuenta creada con éxito! Ya podés ingresar.");
                onNavegar('login');
            } else {
                const errorData = await response.json();
                setError(errorData.mensaje || "Error al crear la cuenta. Revisa los datos.");
            }
        } catch (err) {
            setError("Error de red. Verificá que el Visual Studio Morado esté corriendo.");
        }
    };

    return (
        <div style={estilos.fullPageWrap}>
            <div style={estilos.splitContainer}>
                
                {/* COLUMNA IZQUIERDA: Branding e Imagen */}
                <div style={estilos.leftColumn}>
                    <h2 style={estilos.brandText}>Sanctuary</h2>
                    <h1 style={estilos.heroTitle}>
                        Tu espacio para el <span style={estilos.textHighlight}>trabajo profundo.</span>
                    </h1>
                    <p style={estilos.heroSubtitle}>
                        Únete a una comunidad diseñada para minimizar el ruido digital y potenciar tu enfoque cognitivo.
                    </p>
                    
                    {/* Imagen Principal del Escritorio */}
                    <img 
                        src="https://lh3.googleusercontent.com/aida-public/AB6AXuDElxO5KJ8ShW3wGcc0bwz096o5m4D3R-JfkTXbYRzSS0jfC4UTdVkKKCdGjWKt11topRSf1AZXKRFW3bv1EOYI4mQY0JKLId0dVaAIAG2WoNrzbvqUbbfxR_9-0MEKpYYjmPkI09ZPdkpqDJS32pTgFF2QPqWxuehGOSz-GRm094pamGnL6AC9zPfoFfwmkaY5-Cu6w_GCmkAwoi5hDYVz-tlNBL1gO5rYTLRVXvD5li2j1SK_zPCEdamwBJWDzMQ2Kh3ttrxYvHBX" 
                        alt="Espacio de trabajo Sanctuary" 
                        style={estilos.heroImage} 
                    />
                </div>

                {/* COLUMNA DERECHA: Formulario */}
                <div style={estilos.rightColumn}>
                    <form style={estilos.card} onSubmit={manejarEnvio}>
                        <h2 style={estilos.formTitle}>Crear cuenta</h2>
                        <p style={estilos.formSubtitle}>Empieza hoy tu camino hacia la productividad consciente.</p>

                        {error && <p style={estilos.errorMsg}>{error}</p>}

                        <div style={estilos.inputGroup}>
                            <label style={estilos.inputLabel}>NOMBRE COMPLETO</label>
                            <div style={estilos.inputIconWrap}>
                                <span style={estilos.inputIcon}>👤</span>
                                <input type="text" name="nombre" value={formData.nombre} onChange={manejarCambio} placeholder="Ej. Alex Rivera" style={estilos.textInput} required />
                            </div>
                        </div>

                        <div style={estilos.inputGroup}>
                            <label style={estilos.inputLabel}>EMAIL</label>
                            <div style={estilos.inputIconWrap}>
                                <span style={estilos.inputIcon}>✉️</span>
                                <input type="email" name="email" value={formData.email} onChange={manejarCambio} placeholder="nombre@ejemplo.com" style={estilos.textInput} required />
                            </div>
                        </div>

                        <div style={estilos.inputGroup}>
                            <label style={estilos.inputLabel}>CONTRASEÑA</label>
                            <div style={estilos.inputIconWrap}>
                                <span style={estilos.inputIcon}>🔒</span>
                                <input type="password" name="password" value={formData.password} onChange={manejarCambio} placeholder="........" style={estilos.textInput} required />
                            </div>
                        </div>

                        <div style={estilos.inputGroup}>
                            <label style={estilos.inputLabel}>CONFIRMAR CONTRASEÑA</label>
                            <div style={estilos.inputIconWrap}>
                                <span style={estilos.inputIcon}>🔄</span>
                                <input type="password" name="confirmPassword" value={formData.confirmPassword} onChange={manejarCambio} placeholder="........" style={estilos.textInput} required />
                            </div>
                        </div>

                        <button type="submit" style={estilos.mainBtn}>Crear Cuenta</button>

                        <div style={estilos.loginRedirect}>
                            <span>¿Ya tengo cuenta? </span>
                            <button type="button" style={estilos.linkBtn} onClick={() => onNavegar('login')}>Iniciar sesión</button>
                        </div>

                        <p style={estilos.termsText}>
                            Al crear una cuenta, aceptas nuestros <a href="#">Términos de Servicio</a> y nuestra <a href="#">Política de Privacidad</a>.
                        </p>
                    </form>
                </div>
            </div>

            <footer style={estilos.footer}>
                © 2026 Sanctuary Sanctuary. Diseñado para Deep Work. • Privacy Policy • Terms of Service • Help Center
            </footer>
        </div>
    );
};

// --- OBJETO DE ESTILOS ACTUALIZADO PARA LA FORMA DE 2 COLUMNAS ---
const estilos = {
    fullPageWrap: { 
        fontFamily: "'Inter', sans-serif", 
        backgroundColor: '#F6F8FE', 
        minHeight: '100vh', 
        display: 'flex', 
        flexDirection: 'column', 
        alignItems: 'center', 
        justifyContent: 'center', 
        padding: '20px' 
    },
    splitContainer: { 
        display: 'flex', 
        width: '100%', 
        maxWidth: '1100px', 
        gap: '60px', 
        alignItems: 'center', 
        flex: 1 
    },
    
    // Columna Izquierda
    leftColumn: { 
        flex: 1, 
        paddingRight: '20px',
        textAlign: 'left'
    },
    brandText: { color: '#3A56AF', fontSize: '1.2rem', fontWeight: '700', marginBottom: '15px' },
    heroTitle: { fontSize: '3.5rem', fontWeight: '800', color: '#2D3247', lineHeight: '1.1', marginBottom: '20px' },
    textHighlight: { color: '#3A56AF' },
    heroSubtitle: { fontSize: '1.2rem', color: '#6B728E', lineHeight: '1.6', marginBottom: '40px', maxWidth: '90%' },
    heroImage: { 
        width: '100%', 
        height: '400px', 
        borderRadius: '20px', 
        objectFit: 'cover', 
        boxShadow: '0 10px 30px rgba(0,0,0,0.08)' 
    },
    
    // Columna Derecha (Tarjeta)
    rightColumn: { width: '460px' },
    card: { 
        backgroundColor: 'white', 
        padding: '50px', 
        borderRadius: '20px', 
        border: '1px solid #E8EBFF', 
        boxShadow: '0 10px 40px rgba(0,0,0,0.04)' 
    },
    formTitle: { fontSize: '2.2rem', fontWeight: '800', color: '#2D3247', margin: '0 0 10px 0' },
    formSubtitle: { fontSize: '1rem', color: '#9EA5BA', fontWeight: '500', margin: '0 0 35px 0' },
    errorMsg: { color: '#E53E3E', fontWeight: '600', marginBottom: '20px', fontSize: '0.9rem', backgroundColor: '#FFF5F5', padding: '10px', borderRadius: '8px', border: '1px solid #FED7D7' },
    
    inputGroup: { marginBottom: '20px' },
    inputLabel: { display: 'block', fontSize: '0.8rem', color: '#9EA5BA', fontWeight: '700', letterSpacing: '1px', marginBottom: '8px' },
    inputIconWrap: { position: 'relative' },
    inputIcon: { position: 'absolute', top: '50%', left: '15px', transform: 'translateY(-50%)', color: '#9EA5BA', fontSize: '1.1rem', opacity: 0.7 },
    textInput: { 
        width: '100%', 
        padding: '14px 14px 14px 45px', 
        borderRadius: '12px', 
        border: '1px solid #E8EBFF', 
        backgroundColor: '#F9FBFF', 
        fontSize: '1rem', 
        color: '#2D3247', 
        outline: 'none', 
        boxSizing: 'border-box',
        transition: 'border-color 0.2s'
    },
    
    mainBtn: { 
        width: '100%', 
        backgroundColor: '#3A56AF', 
        color: 'white', 
        border: 'none', 
        borderRadius: '12px', 
        padding: '16px', 
        fontSize: '1.1rem', 
        fontWeight: '700', 
        cursor: 'pointer', 
        marginTop: '10px', 
        boxShadow: '0 6px 20px rgba(58, 86, 175, 0.25)',
        transition: 'transform 0.1s'
    },
    
    loginRedirect: { textAlign: 'center', marginTop: '25px', fontSize: '1rem', color: '#6B728E' },
    linkBtn: { background: 'none', border: 'none', color: '#3A56AF', fontWeight: '700', cursor: 'pointer', fontSize: '1rem', padding: 0, marginLeft: '5px' },
    termsText: { fontSize: '0.75rem', color: '#9EA5BA', textAlign: 'center', marginTop: '30px', lineHeight: '1.6' },
    
    footer: { fontSize: '0.85rem', color: '#9EA5BA', fontWeight: '500', opacity: 0.7, marginTop: '40px', textAlign: 'center', width: '100%', paddingBottom: '20px' }
};

export default Registro;