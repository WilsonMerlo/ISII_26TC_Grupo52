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

    // 1. Validación de interfaz (Frontend)
    if (formData.password !== formData.confirmPassword) {
        setError("Las contraseñas no coinciden.");
        return;
    }

    // 2. Armamos el "Contrato de Datos" (JSON)
    // IMPORTANTE: Los nombres de la izquierda deben ser IGUALES a los de tu modelo en C#
    const nuevoUsuario = {
        nombre: formData.nombre,
        correo: formData.email,
        contrasenia: formData.password // Cambiado de 'password' a 'contrasenia'
    };

    try {
        const response = await fetch("https://localhost:7068/api/Usuarios", {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(nuevoUsuario)
        });

        if (response.ok) {
            // Si el status es 200-299
            alert("¡Cuenta creada con éxito! Ya podés entrar.");
            onNavegar('login');
        } else {
            // Si el servidor responde con un error (400, 500, etc.)
            // Intentamos leer el mensaje que manda el backend
            const errorData = await response.json();
            console.log("Detalle del error del servidor:", errorData);
            
            setError(errorData.mensaje || "Error al crear la cuenta. Revisa los datos.");
        }
    } catch (err) {
        // Si ni siquiera llega al servidor (Server apagado o error de red)
        setError("Error de red.");
    }
};
    return (
        <div style={estilos.fullPageWrap}>
            <div style={estilos.splitContainer}>
                
                {/* COLUMNA IZQUIERDA (Marketing & Branding) */}
                <div style={estilos.leftColumn}>
                    <h2 style={estilos.brandText}>Sanctuary</h2>
                    <h1 style={estilos.heroTitle}>Tu espacio para el <span style={estilos.textHighlight}>trabajo profundo.</span></h1>
                    <p style={estilos.heroSubtitle}>
                        Únete a una comunidad diseñada para minimizar el ruido digital y potenciar tu enfoque cognitivo.
                    </p>
                    
                    {/* Placeholder de la imagen del escritorio */}
                    <div style={estilos.imagePlaceholder}>
                        <div style={estilos.mockMonitor}>🖥️ Espacio de Trabajo</div>
                    </div>
                </div>

                {/* COLUMNA DERECHA (Formulario de Registro) */}
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

const estilos = {
    fullPageWrap: { fontFamily: "'Inter', sans-serif", backgroundColor: '#F6F8FE', minHeight: '100vh', display: 'flex', flexDirection: 'column', alignItems: 'center', justifyContent: 'center', padding: '20px' },
    splitContainer: { display: 'flex', width: '100%', maxWidth: '1100px', gap: '50px', alignItems: 'center', flex: 1 },
    
    // Izquierda
    leftColumn: { flex: 1, paddingRight: '20px' },
    brandText: { color: '#3A56AF', fontSize: '1.2rem', fontWeight: '700', marginBottom: '15px' },
    heroTitle: { fontSize: '3.5rem', fontWeight: '800', color: '#2D3247', lineHeight: '1.1', marginBottom: '20px' },
    textHighlight: { color: '#3A56AF' },
    heroSubtitle: { fontSize: '1.2rem', color: '#6B728E', lineHeight: '1.6', marginBottom: '40px', maxWidth: '80%' },
    imagePlaceholder: { width: '100%', height: '300px', backgroundColor: '#E8EBFF', borderRadius: '15px', display: 'flex', justifyContent: 'center', alignItems: 'center', border: '1px dashed #9EA5BA' },
    mockMonitor: { fontSize: '1.5rem', color: '#3A56AF', fontWeight: '600', opacity: 0.5 },
    
    // Derecha (Form)
    rightColumn: { width: '450px' },
    card: { backgroundColor: 'white', padding: '40px', borderRadius: '15px', border: '1px solid #E8EBFF', boxShadow: '0 4px 20px rgba(0,0,0,0.03)' },
    formTitle: { fontSize: '2rem', fontWeight: '800', color: '#2D3247', margin: '0 0 5px 0' },
    formSubtitle: { fontSize: '0.9rem', color: '#9EA5BA', fontWeight: '500', margin: '0 0 30px 0' },
    errorMsg: { color: 'red', fontWeight: '600', marginBottom: '15px', fontSize: '0.9rem' },
    
    inputGroup: { marginBottom: '18px' },
    inputLabel: { display: 'block', fontSize: '0.75rem', color: '#9EA5BA', fontWeight: '700', letterSpacing: '1px', marginBottom: '8px' },
    inputIconWrap: { position: 'relative' },
    inputIcon: { position: 'absolute', top: '50%', left: '15px', transform: 'translateY(-50%)', color: '#9EA5BA', fontSize: '1rem', opacity: 0.6 },
    textInput: { width: '100%', padding: '12px 12px 12px 40px', borderRadius: '8px', border: '1px solid #E8EBFF', backgroundColor: '#F9FBFF', fontSize: '0.95rem', color: '#2D3247', outline: 'none', boxSizing: 'border-box' },
    
    mainBtn: { width: '100%', backgroundColor: '#3A56AF', color: 'white', border: 'none', borderRadius: '8px', padding: '15px', fontSize: '1rem', fontWeight: '700', cursor: 'pointer', marginTop: '10px', boxShadow: '0 4px 10px rgba(58, 86, 175, 0.2)' },
    
    loginRedirect: { textAlign: 'center', marginTop: '20px', fontSize: '0.9rem', color: '#6B728E' },
    linkBtn: { background: 'none', border: 'none', color: '#3A56AF', fontWeight: '700', cursor: 'pointer', fontSize: '0.9rem', padding: 0 },
    
    termsText: { fontSize: '0.7rem', color: '#9EA5BA', textAlign: 'center', marginTop: '30px', lineHeight: '1.5' },
    
    footer: { fontSize: '0.8rem', color: '#9EA5BA', fontWeight: '500', opacity: 0.6, marginTop: '40px', textAlign: 'center', width: '100%' }
};

export default Registro;