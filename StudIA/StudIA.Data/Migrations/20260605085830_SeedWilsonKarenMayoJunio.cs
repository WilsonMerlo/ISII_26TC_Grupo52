using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudIA.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedWilsonKarenMayoJunio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Apuntes",
                columns: new[] { "id_apunte", "contenido", "fecha_creacion", "fecha_modificacion", "id_materia", "titulo" },
                values: new object[,]
                {
                    { 1, "<h2>Introducción general</h2><p><strong>Materia:</strong> Ingeniería de Software II</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, "Introducción general - Ingeniería de Software II" },
                    { 2, "<h2>Conceptos clave</h2><p><strong>Materia:</strong> Ingeniería de Software II</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, "Conceptos clave - Ingeniería de Software II" },
                    { 3, "<h2>Resumen de clase</h2><p><strong>Materia:</strong> Ingeniería de Software II</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, "Resumen de clase - Ingeniería de Software II" },
                    { 4, "<h2>Ejercicios básicos</h2><p><strong>Materia:</strong> Ingeniería de Software II</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, "Ejercicios básicos - Ingeniería de Software II" },
                    { 5, "<h2>Ejercicios intermedios</h2><p><strong>Materia:</strong> Ingeniería de Software II</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, "Ejercicios intermedios - Ingeniería de Software II" },
                    { 6, "<h2>Errores frecuentes</h2><p><strong>Materia:</strong> Ingeniería de Software II</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, "Errores frecuentes - Ingeniería de Software II" },
                    { 7, "<h2>Guía de repaso</h2><p><strong>Materia:</strong> Ingeniería de Software II</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, "Guía de repaso - Ingeniería de Software II" },
                    { 8, "<h2>Casos prácticos</h2><p><strong>Materia:</strong> Ingeniería de Software II</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, "Casos prácticos - Ingeniería de Software II" },
                    { 9, "<h2>Preguntas de examen</h2><p><strong>Materia:</strong> Ingeniería de Software II</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, "Preguntas de examen - Ingeniería de Software II" },
                    { 10, "<h2>Mapa conceptual</h2><p><strong>Materia:</strong> Ingeniería de Software II</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mapa conceptual - Ingeniería de Software II" },
                    { 11, "<h2>Introducción general</h2><p><strong>Materia:</strong> Cálculo</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, "Introducción general - Cálculo" },
                    { 12, "<h2>Conceptos clave</h2><p><strong>Materia:</strong> Cálculo</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, "Conceptos clave - Cálculo" },
                    { 13, "<h2>Resumen de clase</h2><p><strong>Materia:</strong> Cálculo</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, "Resumen de clase - Cálculo" },
                    { 14, "<h2>Ejercicios básicos</h2><p><strong>Materia:</strong> Cálculo</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, "Ejercicios básicos - Cálculo" },
                    { 15, "<h2>Ejercicios intermedios</h2><p><strong>Materia:</strong> Cálculo</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, "Ejercicios intermedios - Cálculo" },
                    { 16, "<h2>Errores frecuentes</h2><p><strong>Materia:</strong> Cálculo</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, "Errores frecuentes - Cálculo" },
                    { 17, "<h2>Guía de repaso</h2><p><strong>Materia:</strong> Cálculo</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, "Guía de repaso - Cálculo" },
                    { 18, "<h2>Casos prácticos</h2><p><strong>Materia:</strong> Cálculo</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, "Casos prácticos - Cálculo" },
                    { 19, "<h2>Preguntas de examen</h2><p><strong>Materia:</strong> Cálculo</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, "Preguntas de examen - Cálculo" },
                    { 20, "<h2>Mapa conceptual</h2><p><strong>Materia:</strong> Cálculo</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, "Mapa conceptual - Cálculo" },
                    { 21, "<h2>Introducción general</h2><p><strong>Materia:</strong> Estadística</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, "Introducción general - Estadística" },
                    { 22, "<h2>Conceptos clave</h2><p><strong>Materia:</strong> Estadística</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, "Conceptos clave - Estadística" },
                    { 23, "<h2>Resumen de clase</h2><p><strong>Materia:</strong> Estadística</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, "Resumen de clase - Estadística" },
                    { 24, "<h2>Ejercicios básicos</h2><p><strong>Materia:</strong> Estadística</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, "Ejercicios básicos - Estadística" },
                    { 25, "<h2>Ejercicios intermedios</h2><p><strong>Materia:</strong> Estadística</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, "Ejercicios intermedios - Estadística" },
                    { 26, "<h2>Errores frecuentes</h2><p><strong>Materia:</strong> Estadística</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, "Errores frecuentes - Estadística" },
                    { 27, "<h2>Guía de repaso</h2><p><strong>Materia:</strong> Estadística</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, "Guía de repaso - Estadística" },
                    { 28, "<h2>Casos prácticos</h2><p><strong>Materia:</strong> Estadística</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, "Casos prácticos - Estadística" },
                    { 29, "<h2>Preguntas de examen</h2><p><strong>Materia:</strong> Estadística</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, "Preguntas de examen - Estadística" },
                    { 30, "<h2>Mapa conceptual</h2><p><strong>Materia:</strong> Estadística</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, "Mapa conceptual - Estadística" }
                });

            migrationBuilder.InsertData(
                table: "Materias",
                columns: new[] { "id_materia", "descripcion", "id_usuario", "nombre_materia" },
                values: new object[,]
                {
                    { 4, "React, C# y desarrollo web", 1, "Programación" },
                    { 5, "Cinemática, dinámica y energía", 1, "Física" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "id_usuario", "contraseña", "correo", "nombre" },
                values: new object[] { 2, "123", "k4s@gmail.com", "Karen Ríos" });

            migrationBuilder.InsertData(
                table: "Apuntes",
                columns: new[] { "id_apunte", "contenido", "fecha_creacion", "fecha_modificacion", "id_materia", "titulo" },
                values: new object[,]
                {
                    { 31, "<h2>Introducción general</h2><p><strong>Materia:</strong> Programación</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), 4, "Introducción general - Programación" },
                    { 32, "<h2>Conceptos clave</h2><p><strong>Materia:</strong> Programación</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), 4, "Conceptos clave - Programación" },
                    { 33, "<h2>Resumen de clase</h2><p><strong>Materia:</strong> Programación</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), 4, "Resumen de clase - Programación" },
                    { 34, "<h2>Ejercicios básicos</h2><p><strong>Materia:</strong> Programación</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), 4, "Ejercicios básicos - Programación" },
                    { 35, "<h2>Ejercicios intermedios</h2><p><strong>Materia:</strong> Programación</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), 4, "Ejercicios intermedios - Programación" },
                    { 36, "<h2>Errores frecuentes</h2><p><strong>Materia:</strong> Programación</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), 4, "Errores frecuentes - Programación" },
                    { 37, "<h2>Guía de repaso</h2><p><strong>Materia:</strong> Programación</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), 4, "Guía de repaso - Programación" },
                    { 38, "<h2>Casos prácticos</h2><p><strong>Materia:</strong> Programación</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), 4, "Casos prácticos - Programación" },
                    { 39, "<h2>Preguntas de examen</h2><p><strong>Materia:</strong> Programación</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), 4, "Preguntas de examen - Programación" },
                    { 40, "<h2>Mapa conceptual</h2><p><strong>Materia:</strong> Programación</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), 4, "Mapa conceptual - Programación" },
                    { 41, "<h2>Introducción general</h2><p><strong>Materia:</strong> Física</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, "Introducción general - Física" },
                    { 42, "<h2>Conceptos clave</h2><p><strong>Materia:</strong> Física</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, "Conceptos clave - Física" },
                    { 43, "<h2>Resumen de clase</h2><p><strong>Materia:</strong> Física</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, "Resumen de clase - Física" },
                    { 44, "<h2>Ejercicios básicos</h2><p><strong>Materia:</strong> Física</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, "Ejercicios básicos - Física" },
                    { 45, "<h2>Ejercicios intermedios</h2><p><strong>Materia:</strong> Física</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, "Ejercicios intermedios - Física" },
                    { 46, "<h2>Errores frecuentes</h2><p><strong>Materia:</strong> Física</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, "Errores frecuentes - Física" },
                    { 47, "<h2>Guía de repaso</h2><p><strong>Materia:</strong> Física</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, "Guía de repaso - Física" },
                    { 48, "<h2>Casos prácticos</h2><p><strong>Materia:</strong> Física</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, "Casos prácticos - Física" },
                    { 49, "<h2>Preguntas de examen</h2><p><strong>Materia:</strong> Física</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, "Preguntas de examen - Física" },
                    { 50, "<h2>Mapa conceptual</h2><p><strong>Materia:</strong> Física</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, "Mapa conceptual - Física" }
                });

            migrationBuilder.InsertData(
                table: "Materias",
                columns: new[] { "id_materia", "descripcion", "id_usuario", "nombre_materia" },
                values: new object[,]
                {
                    { 6, "SQL, normalización y consultas", 2, "Bases de Datos" },
                    { 7, "Lógica, conjuntos y grafos", 2, "Matemática Discreta" },
                    { 8, "CPU, memoria y buses", 2, "Arquitectura de Computadoras" },
                    { 9, "Lectura y vocabulario técnico", 2, "Inglés Técnico" },
                    { 10, "Planificación, riesgos y seguimiento", 2, "Gestión de Proyectos" }
                });

            migrationBuilder.InsertData(
                table: "Pomodoros",
                columns: new[] { "id_pomodoro", "duracion_descanso", "duracion_estudio", "estado", "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[,]
                {
                    { 1, 5, 25, true, new DateTime(2026, 5, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 2, 5, 25, true, new DateTime(2026, 5, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), 12, 2, 1 },
                    { 3, 5, 25, true, new DateTime(2026, 5, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), 23, 3, 1 },
                    { 5, 5, 25, true, new DateTime(2026, 5, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), 12, 2, 1 },
                    { 6, 5, 25, true, new DateTime(2026, 5, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), 23, 3, 1 },
                    { 8, 5, 25, true, new DateTime(2026, 5, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), 23, 3, 1 },
                    { 13, 5, 25, true, new DateTime(2026, 5, 21, 15, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, 1 },
                    { 14, 10, 45, true, new DateTime(2026, 5, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), 17, 2, 1 },
                    { 16, 5, 25, true, new DateTime(2026, 5, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, 1 },
                    { 17, 5, 25, true, new DateTime(2026, 5, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), 17, 2, 1 },
                    { 18, 10, 45, true, new DateTime(2026, 5, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 28, 3, 1 },
                    { 20, 5, 25, true, new DateTime(2026, 5, 23, 9, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, 1 },
                    { 21, 5, 25, true, new DateTime(2026, 5, 23, 11, 0, 0, 0, DateTimeKind.Unspecified), 17, 2, 1 },
                    { 22, 5, 25, true, new DateTime(2026, 5, 24, 9, 0, 0, 0, DateTimeKind.Unspecified), 17, 2, 1 },
                    { 23, 5, 25, true, new DateTime(2026, 5, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), 28, 3, 1 },
                    { 26, 10, 45, true, new DateTime(2026, 5, 25, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 29, 5, 25, true, new DateTime(2026, 5, 26, 15, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 31, 5, 25, true, new DateTime(2026, 5, 27, 11, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 32, 5, 25, true, new DateTime(2026, 5, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), 12, 2, 1 },
                    { 33, 5, 25, true, new DateTime(2026, 5, 28, 9, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 34, 5, 25, true, new DateTime(2026, 5, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), 12, 2, 1 },
                    { 35, 5, 25, true, new DateTime(2026, 5, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), 23, 3, 1 },
                    { 37, 5, 25, true, new DateTime(2026, 5, 29, 9, 0, 0, 0, DateTimeKind.Unspecified), 12, 2, 1 },
                    { 38, 5, 25, true, new DateTime(2026, 5, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), 23, 3, 1 },
                    { 41, 10, 50, true, new DateTime(2026, 5, 29, 20, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, 1 },
                    { 42, 5, 25, true, new DateTime(2026, 5, 30, 9, 0, 0, 0, DateTimeKind.Unspecified), 23, 3, 1 },
                    { 46, 5, 25, true, new DateTime(2026, 6, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, 1 },
                    { 47, 5, 25, true, new DateTime(2026, 6, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), 17, 2, 1 },
                    { 48, 10, 45, true, new DateTime(2026, 6, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 28, 3, 1 },
                    { 49, 5, 25, true, new DateTime(2026, 6, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, 1 },
                    { 50, 5, 25, true, new DateTime(2026, 6, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), 17, 2, 1 },
                    { 51, 5, 25, true, new DateTime(2026, 6, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), 28, 3, 1 },
                    { 52, 5, 25, true, new DateTime(2026, 6, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), 17, 2, 1 },
                    { 53, 5, 25, true, new DateTime(2026, 6, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 28, 3, 1 },
                    { 55, 5, 25, true, new DateTime(2026, 6, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), 28, 3, 1 },
                    { 58, 10, 45, true, new DateTime(2026, 6, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 61, 5, 25, true, new DateTime(2026, 6, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 62, 10, 45, true, new DateTime(2026, 6, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), 12, 2, 1 },
                    { 63, 10, 50, true, new DateTime(2026, 6, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), 23, 3, 1 },
                    { 65, 5, 25, true, new DateTime(2026, 6, 6, 11, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 66, 5, 25, true, new DateTime(2026, 6, 7, 9, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 67, 5, 25, true, new DateTime(2026, 6, 8, 9, 0, 0, 0, DateTimeKind.Unspecified), 12, 2, 1 },
                    { 68, 5, 25, true, new DateTime(2026, 6, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), 23, 3, 1 },
                    { 71, 5, 25, true, new DateTime(2026, 6, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), 23, 3, 1 },
                    { 76, 5, 25, true, new DateTime(2026, 6, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Apuntes",
                columns: new[] { "id_apunte", "contenido", "fecha_creacion", "fecha_modificacion", "id_materia", "titulo" },
                values: new object[,]
                {
                    { 51, "<h2>Introducción general</h2><p><strong>Materia:</strong> Bases de Datos</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, "Introducción general - Bases de Datos" },
                    { 52, "<h2>Conceptos clave</h2><p><strong>Materia:</strong> Bases de Datos</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, "Conceptos clave - Bases de Datos" },
                    { 53, "<h2>Resumen de clase</h2><p><strong>Materia:</strong> Bases de Datos</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, "Resumen de clase - Bases de Datos" },
                    { 54, "<h2>Ejercicios básicos</h2><p><strong>Materia:</strong> Bases de Datos</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, "Ejercicios básicos - Bases de Datos" },
                    { 55, "<h2>Ejercicios intermedios</h2><p><strong>Materia:</strong> Bases de Datos</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, "Ejercicios intermedios - Bases de Datos" },
                    { 56, "<h2>Errores frecuentes</h2><p><strong>Materia:</strong> Bases de Datos</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, "Errores frecuentes - Bases de Datos" },
                    { 57, "<h2>Guía de repaso</h2><p><strong>Materia:</strong> Bases de Datos</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, "Guía de repaso - Bases de Datos" },
                    { 58, "<h2>Casos prácticos</h2><p><strong>Materia:</strong> Bases de Datos</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, "Casos prácticos - Bases de Datos" },
                    { 59, "<h2>Preguntas de examen</h2><p><strong>Materia:</strong> Bases de Datos</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, "Preguntas de examen - Bases de Datos" },
                    { 60, "<h2>Mapa conceptual</h2><p><strong>Materia:</strong> Bases de Datos</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, "Mapa conceptual - Bases de Datos" },
                    { 61, "<h2>Introducción general</h2><p><strong>Materia:</strong> Matemática Discreta</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), 7, "Introducción general - Matemática Discreta" },
                    { 62, "<h2>Conceptos clave</h2><p><strong>Materia:</strong> Matemática Discreta</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), 7, "Conceptos clave - Matemática Discreta" },
                    { 63, "<h2>Resumen de clase</h2><p><strong>Materia:</strong> Matemática Discreta</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), 7, "Resumen de clase - Matemática Discreta" },
                    { 64, "<h2>Ejercicios básicos</h2><p><strong>Materia:</strong> Matemática Discreta</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), 7, "Ejercicios básicos - Matemática Discreta" },
                    { 65, "<h2>Ejercicios intermedios</h2><p><strong>Materia:</strong> Matemática Discreta</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), 7, "Ejercicios intermedios - Matemática Discreta" },
                    { 66, "<h2>Errores frecuentes</h2><p><strong>Materia:</strong> Matemática Discreta</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), 7, "Errores frecuentes - Matemática Discreta" },
                    { 67, "<h2>Guía de repaso</h2><p><strong>Materia:</strong> Matemática Discreta</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), 7, "Guía de repaso - Matemática Discreta" },
                    { 68, "<h2>Casos prácticos</h2><p><strong>Materia:</strong> Matemática Discreta</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), 7, "Casos prácticos - Matemática Discreta" },
                    { 69, "<h2>Preguntas de examen</h2><p><strong>Materia:</strong> Matemática Discreta</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), 7, "Preguntas de examen - Matemática Discreta" },
                    { 70, "<h2>Mapa conceptual</h2><p><strong>Materia:</strong> Matemática Discreta</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), 7, "Mapa conceptual - Matemática Discreta" },
                    { 71, "<h2>Introducción general</h2><p><strong>Materia:</strong> Arquitectura de Computadoras</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), 8, "Introducción general - Arquitectura de Computadoras" },
                    { 72, "<h2>Conceptos clave</h2><p><strong>Materia:</strong> Arquitectura de Computadoras</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), 8, "Conceptos clave - Arquitectura de Computadoras" },
                    { 73, "<h2>Resumen de clase</h2><p><strong>Materia:</strong> Arquitectura de Computadoras</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), 8, "Resumen de clase - Arquitectura de Computadoras" },
                    { 74, "<h2>Ejercicios básicos</h2><p><strong>Materia:</strong> Arquitectura de Computadoras</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), 8, "Ejercicios básicos - Arquitectura de Computadoras" },
                    { 75, "<h2>Ejercicios intermedios</h2><p><strong>Materia:</strong> Arquitectura de Computadoras</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), 8, "Ejercicios intermedios - Arquitectura de Computadoras" },
                    { 76, "<h2>Errores frecuentes</h2><p><strong>Materia:</strong> Arquitectura de Computadoras</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), 8, "Errores frecuentes - Arquitectura de Computadoras" },
                    { 77, "<h2>Guía de repaso</h2><p><strong>Materia:</strong> Arquitectura de Computadoras</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), 8, "Guía de repaso - Arquitectura de Computadoras" },
                    { 78, "<h2>Casos prácticos</h2><p><strong>Materia:</strong> Arquitectura de Computadoras</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), 8, "Casos prácticos - Arquitectura de Computadoras" },
                    { 79, "<h2>Preguntas de examen</h2><p><strong>Materia:</strong> Arquitectura de Computadoras</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), 8, "Preguntas de examen - Arquitectura de Computadoras" },
                    { 80, "<h2>Mapa conceptual</h2><p><strong>Materia:</strong> Arquitectura de Computadoras</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), 8, "Mapa conceptual - Arquitectura de Computadoras" },
                    { 81, "<h2>Introducción general</h2><p><strong>Materia:</strong> Inglés Técnico</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), 9, "Introducción general - Inglés Técnico" },
                    { 82, "<h2>Conceptos clave</h2><p><strong>Materia:</strong> Inglés Técnico</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), 9, "Conceptos clave - Inglés Técnico" },
                    { 83, "<h2>Resumen de clase</h2><p><strong>Materia:</strong> Inglés Técnico</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), 9, "Resumen de clase - Inglés Técnico" },
                    { 84, "<h2>Ejercicios básicos</h2><p><strong>Materia:</strong> Inglés Técnico</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), 9, "Ejercicios básicos - Inglés Técnico" },
                    { 85, "<h2>Ejercicios intermedios</h2><p><strong>Materia:</strong> Inglés Técnico</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), 9, "Ejercicios intermedios - Inglés Técnico" },
                    { 86, "<h2>Errores frecuentes</h2><p><strong>Materia:</strong> Inglés Técnico</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), 9, "Errores frecuentes - Inglés Técnico" },
                    { 87, "<h2>Guía de repaso</h2><p><strong>Materia:</strong> Inglés Técnico</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), 9, "Guía de repaso - Inglés Técnico" },
                    { 88, "<h2>Casos prácticos</h2><p><strong>Materia:</strong> Inglés Técnico</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), 9, "Casos prácticos - Inglés Técnico" },
                    { 89, "<h2>Preguntas de examen</h2><p><strong>Materia:</strong> Inglés Técnico</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), 9, "Preguntas de examen - Inglés Técnico" },
                    { 90, "<h2>Mapa conceptual</h2><p><strong>Materia:</strong> Inglés Técnico</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), 9, "Mapa conceptual - Inglés Técnico" },
                    { 91, "<h2>Introducción general</h2><p><strong>Materia:</strong> Gestión de Proyectos</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), 10, "Introducción general - Gestión de Proyectos" },
                    { 92, "<h2>Conceptos clave</h2><p><strong>Materia:</strong> Gestión de Proyectos</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), 10, "Conceptos clave - Gestión de Proyectos" },
                    { 93, "<h2>Resumen de clase</h2><p><strong>Materia:</strong> Gestión de Proyectos</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), 10, "Resumen de clase - Gestión de Proyectos" },
                    { 94, "<h2>Ejercicios básicos</h2><p><strong>Materia:</strong> Gestión de Proyectos</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), 10, "Ejercicios básicos - Gestión de Proyectos" },
                    { 95, "<h2>Ejercicios intermedios</h2><p><strong>Materia:</strong> Gestión de Proyectos</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), 10, "Ejercicios intermedios - Gestión de Proyectos" },
                    { 96, "<h2>Errores frecuentes</h2><p><strong>Materia:</strong> Gestión de Proyectos</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), 10, "Errores frecuentes - Gestión de Proyectos" },
                    { 97, "<h2>Guía de repaso</h2><p><strong>Materia:</strong> Gestión de Proyectos</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), 10, "Guía de repaso - Gestión de Proyectos" },
                    { 98, "<h2>Casos prácticos</h2><p><strong>Materia:</strong> Gestión de Proyectos</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), 10, "Casos prácticos - Gestión de Proyectos" },
                    { 99, "<h2>Preguntas de examen</h2><p><strong>Materia:</strong> Gestión de Proyectos</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), 10, "Preguntas de examen - Gestión de Proyectos" },
                    { 100, "<h2>Mapa conceptual</h2><p><strong>Materia:</strong> Gestión de Proyectos</p><p>Contenido de práctica para cargar estadísticas y probar la vista de apuntes.</p>", new DateTime(2026, 5, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), 10, "Mapa conceptual - Gestión de Proyectos" }
                });

            migrationBuilder.InsertData(
                table: "Pomodoros",
                columns: new[] { "id_pomodoro", "duracion_descanso", "duracion_estudio", "estado", "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[,]
                {
                    { 4, 10, 45, true, new DateTime(2026, 5, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), 34, 4, 1 },
                    { 7, 5, 25, true, new DateTime(2026, 5, 19, 15, 0, 0, 0, DateTimeKind.Unspecified), 34, 4, 1 },
                    { 9, 5, 25, true, new DateTime(2026, 5, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), 34, 4, 1 },
                    { 10, 5, 25, true, new DateTime(2026, 5, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), 45, 5, 1 },
                    { 11, 5, 25, true, new DateTime(2026, 5, 21, 9, 0, 0, 0, DateTimeKind.Unspecified), 34, 4, 1 },
                    { 12, 5, 25, true, new DateTime(2026, 5, 21, 11, 0, 0, 0, DateTimeKind.Unspecified), 45, 5, 1 },
                    { 15, 5, 25, true, new DateTime(2026, 5, 22, 9, 0, 0, 0, DateTimeKind.Unspecified), 45, 5, 1 },
                    { 19, 10, 50, true, new DateTime(2026, 5, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), 39, 4, 1 },
                    { 24, 5, 25, true, new DateTime(2026, 5, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), 39, 4, 1 },
                    { 25, 5, 25, true, new DateTime(2026, 5, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), 50, 5, 1 },
                    { 27, 5, 25, true, new DateTime(2026, 5, 26, 9, 0, 0, 0, DateTimeKind.Unspecified), 39, 4, 1 },
                    { 28, 5, 25, true, new DateTime(2026, 5, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), 50, 5, 1 },
                    { 30, 5, 25, true, new DateTime(2026, 5, 27, 9, 0, 0, 0, DateTimeKind.Unspecified), 50, 5, 1 },
                    { 36, 10, 45, true, new DateTime(2026, 5, 28, 18, 0, 0, 0, DateTimeKind.Unspecified), 34, 4, 1 },
                    { 39, 5, 25, true, new DateTime(2026, 5, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), 34, 4, 1 },
                    { 40, 10, 45, true, new DateTime(2026, 5, 29, 18, 0, 0, 0, DateTimeKind.Unspecified), 45, 5, 1 },
                    { 43, 5, 25, true, new DateTime(2026, 5, 30, 11, 0, 0, 0, DateTimeKind.Unspecified), 34, 4, 1 },
                    { 44, 5, 25, true, new DateTime(2026, 5, 31, 9, 0, 0, 0, DateTimeKind.Unspecified), 34, 4, 1 },
                    { 45, 5, 25, true, new DateTime(2026, 6, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 45, 5, 1 },
                    { 54, 5, 25, true, new DateTime(2026, 6, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 39, 4, 1 },
                    { 56, 5, 25, true, new DateTime(2026, 6, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), 39, 4, 1 },
                    { 57, 5, 25, true, new DateTime(2026, 6, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), 50, 5, 1 },
                    { 59, 5, 25, true, new DateTime(2026, 6, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), 39, 4, 1 },
                    { 60, 5, 25, true, new DateTime(2026, 6, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), 50, 5, 1 },
                    { 64, 5, 25, true, new DateTime(2026, 6, 6, 9, 0, 0, 0, DateTimeKind.Unspecified), 50, 5, 1 },
                    { 69, 5, 25, true, new DateTime(2026, 6, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), 34, 4, 1 },
                    { 70, 10, 45, true, new DateTime(2026, 6, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 45, 5, 1 },
                    { 72, 5, 25, true, new DateTime(2026, 6, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), 34, 4, 1 },
                    { 73, 5, 25, true, new DateTime(2026, 6, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), 45, 5, 1 },
                    { 74, 5, 25, true, new DateTime(2026, 6, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), 34, 4, 1 },
                    { 75, 5, 25, true, new DateTime(2026, 6, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), 45, 5, 1 },
                    { 77, 5, 25, true, new DateTime(2026, 5, 18, 8, 30, 0, 0, DateTimeKind.Unspecified), 73, 8, 2 },
                    { 78, 5, 25, true, new DateTime(2026, 5, 18, 13, 0, 0, 0, DateTimeKind.Unspecified), 85, 9, 2 },
                    { 79, 5, 25, true, new DateTime(2026, 5, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 97, 10, 2 },
                    { 80, 5, 25, true, new DateTime(2026, 5, 19, 8, 30, 0, 0, DateTimeKind.Unspecified), 84, 9, 2 },
                    { 81, 5, 25, true, new DateTime(2026, 5, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), 96, 10, 2 },
                    { 82, 5, 25, true, new DateTime(2026, 5, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 58, 6, 2 },
                    { 83, 10, 45, true, new DateTime(2026, 5, 19, 19, 0, 0, 0, DateTimeKind.Unspecified), 70, 7, 2 },
                    { 84, 5, 25, true, new DateTime(2026, 5, 20, 8, 30, 0, 0, DateTimeKind.Unspecified), 95, 10, 2 },
                    { 85, 5, 25, true, new DateTime(2026, 5, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), 57, 6, 2 },
                    { 86, 5, 25, true, new DateTime(2026, 5, 21, 8, 30, 0, 0, DateTimeKind.Unspecified), 56, 6, 2 },
                    { 87, 5, 25, true, new DateTime(2026, 5, 21, 13, 0, 0, 0, DateTimeKind.Unspecified), 68, 7, 2 },
                    { 88, 5, 25, true, new DateTime(2026, 5, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 80, 8, 2 },
                    { 89, 5, 25, true, new DateTime(2026, 5, 22, 8, 30, 0, 0, DateTimeKind.Unspecified), 67, 7, 2 },
                    { 90, 5, 25, true, new DateTime(2026, 5, 22, 13, 0, 0, 0, DateTimeKind.Unspecified), 79, 8, 2 },
                    { 91, 5, 25, true, new DateTime(2026, 5, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 81, 9, 2 },
                    { 92, 5, 25, true, new DateTime(2026, 5, 23, 8, 30, 0, 0, DateTimeKind.Unspecified), 78, 8, 2 },
                    { 93, 5, 25, true, new DateTime(2026, 5, 24, 8, 30, 0, 0, DateTimeKind.Unspecified), 89, 9, 2 },
                    { 94, 5, 25, true, new DateTime(2026, 5, 24, 13, 0, 0, 0, DateTimeKind.Unspecified), 91, 10, 2 },
                    { 95, 5, 25, true, new DateTime(2026, 5, 25, 8, 30, 0, 0, DateTimeKind.Unspecified), 100, 10, 2 },
                    { 96, 5, 25, true, new DateTime(2026, 5, 25, 13, 0, 0, 0, DateTimeKind.Unspecified), 52, 6, 2 },
                    { 97, 5, 25, true, new DateTime(2026, 5, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 64, 7, 2 },
                    { 98, 5, 25, true, new DateTime(2026, 5, 26, 8, 30, 0, 0, DateTimeKind.Unspecified), 51, 6, 2 },
                    { 99, 5, 25, true, new DateTime(2026, 5, 26, 13, 0, 0, 0, DateTimeKind.Unspecified), 63, 7, 2 },
                    { 100, 5, 25, true, new DateTime(2026, 5, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 75, 8, 2 },
                    { 101, 10, 45, true, new DateTime(2026, 5, 26, 19, 0, 0, 0, DateTimeKind.Unspecified), 87, 9, 2 },
                    { 102, 5, 25, true, new DateTime(2026, 5, 27, 8, 30, 0, 0, DateTimeKind.Unspecified), 62, 7, 2 },
                    { 103, 5, 25, true, new DateTime(2026, 5, 27, 13, 0, 0, 0, DateTimeKind.Unspecified), 74, 8, 2 },
                    { 104, 5, 25, true, new DateTime(2026, 5, 28, 8, 30, 0, 0, DateTimeKind.Unspecified), 73, 8, 2 },
                    { 105, 5, 25, true, new DateTime(2026, 5, 28, 13, 0, 0, 0, DateTimeKind.Unspecified), 85, 9, 2 },
                    { 106, 5, 25, true, new DateTime(2026, 5, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 97, 10, 2 },
                    { 107, 5, 25, true, new DateTime(2026, 5, 29, 8, 30, 0, 0, DateTimeKind.Unspecified), 84, 9, 2 },
                    { 108, 5, 25, true, new DateTime(2026, 5, 29, 13, 0, 0, 0, DateTimeKind.Unspecified), 96, 10, 2 },
                    { 109, 5, 25, true, new DateTime(2026, 5, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 58, 6, 2 },
                    { 110, 5, 25, true, new DateTime(2026, 5, 30, 8, 30, 0, 0, DateTimeKind.Unspecified), 95, 10, 2 },
                    { 111, 5, 25, true, new DateTime(2026, 5, 31, 8, 30, 0, 0, DateTimeKind.Unspecified), 56, 6, 2 },
                    { 112, 5, 25, true, new DateTime(2026, 5, 31, 13, 0, 0, 0, DateTimeKind.Unspecified), 68, 7, 2 },
                    { 113, 5, 25, true, new DateTime(2026, 6, 1, 8, 30, 0, 0, DateTimeKind.Unspecified), 67, 7, 2 },
                    { 114, 5, 25, true, new DateTime(2026, 6, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), 79, 8, 2 },
                    { 115, 5, 25, true, new DateTime(2026, 6, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 81, 9, 2 },
                    { 116, 5, 25, true, new DateTime(2026, 6, 2, 8, 30, 0, 0, DateTimeKind.Unspecified), 78, 8, 2 },
                    { 117, 5, 25, true, new DateTime(2026, 6, 2, 13, 0, 0, 0, DateTimeKind.Unspecified), 90, 9, 2 },
                    { 118, 5, 25, true, new DateTime(2026, 6, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 92, 10, 2 },
                    { 119, 10, 45, true, new DateTime(2026, 6, 2, 19, 0, 0, 0, DateTimeKind.Unspecified), 54, 6, 2 },
                    { 120, 5, 25, true, new DateTime(2026, 6, 3, 8, 30, 0, 0, DateTimeKind.Unspecified), 89, 9, 2 },
                    { 121, 5, 25, true, new DateTime(2026, 6, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), 91, 10, 2 },
                    { 122, 5, 25, true, new DateTime(2026, 6, 4, 8, 30, 0, 0, DateTimeKind.Unspecified), 100, 10, 2 },
                    { 123, 5, 25, true, new DateTime(2026, 6, 4, 13, 0, 0, 0, DateTimeKind.Unspecified), 52, 6, 2 },
                    { 124, 5, 25, true, new DateTime(2026, 6, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 64, 7, 2 },
                    { 125, 5, 25, true, new DateTime(2026, 6, 5, 8, 30, 0, 0, DateTimeKind.Unspecified), 51, 6, 2 },
                    { 126, 5, 25, true, new DateTime(2026, 6, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), 63, 7, 2 },
                    { 127, 5, 25, true, new DateTime(2026, 6, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 75, 8, 2 },
                    { 128, 5, 25, true, new DateTime(2026, 6, 6, 8, 30, 0, 0, DateTimeKind.Unspecified), 62, 7, 2 },
                    { 129, 5, 25, true, new DateTime(2026, 6, 7, 8, 30, 0, 0, DateTimeKind.Unspecified), 73, 8, 2 },
                    { 130, 5, 25, true, new DateTime(2026, 6, 7, 13, 0, 0, 0, DateTimeKind.Unspecified), 85, 9, 2 },
                    { 131, 5, 25, true, new DateTime(2026, 6, 8, 8, 30, 0, 0, DateTimeKind.Unspecified), 84, 9, 2 },
                    { 132, 5, 25, true, new DateTime(2026, 6, 8, 13, 0, 0, 0, DateTimeKind.Unspecified), 96, 10, 2 },
                    { 133, 5, 25, true, new DateTime(2026, 6, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 58, 6, 2 },
                    { 134, 5, 25, true, new DateTime(2026, 6, 9, 8, 30, 0, 0, DateTimeKind.Unspecified), 95, 10, 2 },
                    { 135, 5, 25, true, new DateTime(2026, 6, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), 57, 6, 2 },
                    { 136, 5, 25, true, new DateTime(2026, 6, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 69, 7, 2 },
                    { 137, 10, 45, true, new DateTime(2026, 6, 9, 19, 0, 0, 0, DateTimeKind.Unspecified), 71, 8, 2 },
                    { 138, 5, 25, true, new DateTime(2026, 6, 10, 8, 30, 0, 0, DateTimeKind.Unspecified), 56, 6, 2 },
                    { 139, 5, 25, true, new DateTime(2026, 6, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), 68, 7, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Apuntes",
                keyColumn: "id_apunte",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "id_materia",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "id_materia",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "id_materia",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "id_materia",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "id_materia",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "id_materia",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "id_materia",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "id_usuario",
                keyValue: 2);
        }
    }
}
