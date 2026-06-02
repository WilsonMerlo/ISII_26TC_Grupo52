import React, { useState, useRef } from 'react';

const LongPressDelete = ({ onConfirmDelete }) => {
    const [isPressing, setIsPressing] = useState(false);
    const timerRef = useRef(null);

    const iniciarPresion = () => {
        setIsPressing(true);
        // Temporizador a 3000 milisegundos (3 segundos)
        timerRef.current = setTimeout(() => {
            onConfirmDelete();
            setIsPressing(false);
        }, 3000);
    };

    const cancelarPresion = () => {
        setIsPressing(false);
        // Cortamos el cable rojo: abortamos el borrado
        clearTimeout(timerRef.current);
    };

    return (
        <button
            onMouseDown={iniciarPresion}
            onMouseUp={cancelarPresion}
            onMouseLeave={cancelarPresion}
            onTouchStart={iniciarPresion}
            onTouchEnd={cancelarPresion}
            style={estilos.botonContenedor}
            title="Mantén presionado 3s para borrar"
        >
            {/* Barra de progreso visual que se llena en 3s */}
            <div style={{
                ...estilos.barraProgreso,
                width: isPressing ? '100%' : '0%',
                transition: isPressing ? 'width 3s linear' : 'width 0.2s ease'
            }} />
            
            <span style={estilos.textoBoton}>🗑️ Mantener para borrar</span>
        </button>
    );
};

const estilos = {
    botonContenedor: { position: 'relative', overflow: 'hidden', backgroundColor: 'white', border: '1px solid #FFE5E5', borderRadius: '8px', padding: '10px 15px', cursor: 'pointer', outline: 'none' },
    barraProgreso: { position: 'absolute', top: 0, left: 0, height: '100%', backgroundColor: '#FF4D4D', opacity: 0.2, zIndex: 1 },
    textoBoton: { position: 'relative', zIndex: 2, color: '#FF4D4D', fontWeight: '600', fontSize: '0.85rem', pointerEvents: 'none' }
};

export default LongPressDelete;