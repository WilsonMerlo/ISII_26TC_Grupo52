using Microsoft.EntityFrameworkCore;
using StudIA.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudIA.Data;

public class StudIAContext : DbContext
{
    public StudIAContext(DbContextOptions<StudIAContext> options) : base(options) { }

    public DbSet<Usuario> Usuarios { get; set; } = null!;
    public DbSet<Materia> Materias { get; set; } = null!;
    public DbSet<Apunte> Apuntes { get; set; } = null!;
    public DbSet<Pomodoro> Pomodoros { get; set; } = null!;
    public DbSet<Progreso> Progresos { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // =========================================================
        // 1. REGLAS DE RELACIONES Y BORRADO (INTACTAS)
        // =========================================================

        // Relaciones existentes
        modelBuilder.Entity<Materia>()
            .HasOne(m => m.Usuario)
            .WithMany(u => u.Materias)
            .HasForeignKey(m => m.IdUsuario);

        // --- SOLUCIÓN AL ERROR DE CASCADA ORIGINAL ---
        modelBuilder.Entity<Progreso>()
            .HasOne(p => p.Usuario)
            .WithMany()
            .HasForeignKey(p => p.IdUsuario)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Pomodoro>()
            .HasOne(p => p.Usuario)
            .WithMany()
            .HasForeignKey(p => p.IdUsuario)
            .OnDelete(DeleteBehavior.Restrict);
        // ------------------------------------

        // --- NUEVAS REGLAS DE NEGOCIO (Sprint 3) ---

        // REGLA 1: Si se elimina un Apunte, los Pomodoros NO se borran. Pasan a NULL.
        modelBuilder.Entity<Pomodoro>()
            .HasOne(p => p.Apunte)
            .WithMany(a => a.Pomodoros)
            .HasForeignKey(p => p.IdApunte)
            .OnDelete(DeleteBehavior.Restrict);

        // REGLA 2: Si se elimina una Materia, se borran en cascada sus Apuntes.
        modelBuilder.Entity<Apunte>()
            .HasOne(a => a.Materia)
            .WithMany(m => m.Apuntes)
            .HasForeignKey(a => a.IdMateria)
            .OnDelete(DeleteBehavior.Cascade);

        // REGLA 3: Si se elimina una Materia, se borran en cascada sus Pomodoros.
        modelBuilder.Entity<Pomodoro>()
            .HasOne(p => p.Materia)
            .WithMany()
            .HasForeignKey(p => p.IdMateria)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Progreso>()
            .HasOne(p => p.Materia)
            .WithMany()
            .HasForeignKey(p => p.IdMateria)
            .OnDelete(DeleteBehavior.Restrict);


        // =========================================================
        // 2. GENERACIÓN DE SEED DATA (DATOS MASIVOS)
        // =========================================================

        // A. SEMILLA DE USUARIOS
        var usuarios = new List<Usuario>
        {
            new Usuario { IdUsuario = 1, Nombre = "Wilson Merlo", Correo = "wilson@test.com", Contrasena = "1234" },
            new Usuario { IdUsuario = 2, Nombre = "Karen", Correo = "karen@test.com", Contrasena = "1234" }
        };
        modelBuilder.Entity<Usuario>().HasData(usuarios);

        // B. SEMILLA DE MATERIAS (5 para Wilson, 5 para Karen)
        var materias = new List<Materia>
        {
            // Materias de Wilson
            new Materia { IdMateria = 1, IdUsuario = 1, NombreMateria = "Ingeniería de Software II", Descripcion = "Proyecto StudIA" },
            new Materia { IdMateria = 2, IdUsuario = 1, NombreMateria = "Cálculo", Descripcion = "Preparación de finales" },
            new Materia { IdMateria = 3, IdUsuario = 1, NombreMateria = "Estadística", Descripcion = "Modelos probabilísticos" },
            new Materia { IdMateria = 4, IdUsuario = 1, NombreMateria = "Sistemas Operativos", Descripcion = "Concurrencia y memoria" },
            new Materia { IdMateria = 5, IdUsuario = 1, NombreMateria = "Bases de Datos", Descripcion = "SQL y NoSQL" },
            
            // Materias de Karen
            new Materia { IdMateria = 6, IdUsuario = 2, NombreMateria = "Programación Web", Descripcion = "React y Node.js" },
            new Materia { IdMateria = 7, IdUsuario = 2, NombreMateria = "Arquitectura de Software", Descripcion = "Patrones de diseño" },
            new Materia { IdMateria = 8, IdUsuario = 2, NombreMateria = "Matemática Discreta", Descripcion = "Grafos y lógica" },
            new Materia { IdMateria = 9, IdUsuario = 2, NombreMateria = "Redes de Computadoras", Descripcion = "Modelo OSI y TCP/IP" },
            new Materia { IdMateria = 10, IdUsuario = 2, NombreMateria = "Gestión de Proyectos", Descripcion = "Metodologías Ágiles" }
        };
        modelBuilder.Entity<Materia>().HasData(materias);

        // C. SEMILLA DE APUNTES (10 por materia, 2 párrafos c/u)
        var apuntes = new List<Apunte>();
        int apunteId = 1;
        string contenidoApunte = "Este es el primer párrafo del apunte. Aquí se establecen los fundamentos teóricos que se discutieron en la materia, abarcando las definiciones principales, los casos de uso básicos y los diagramas estructurales que aplican a esta unidad específica.\n\nEn este segundo párrafo, se desarrollan los conceptos más avanzados y ejemplos prácticos. Repasar esta sección es fundamental para poder resolver los ejercicios de la guía práctica, entender la bibliografía recomendada y estar bien preparado para el examen integrador.";

        foreach (var materia in materias)
        {
            for (int i = 1; i <= 10; i++)
            {
                apuntes.Add(new Apunte
                {
                    IdApunte = apunteId++,
                    IdMateria = materia.IdMateria,
                    Titulo = $"Unidad {i} - {materia.NombreMateria}",
                    Contenido = contenidoApunte,
                    FechaCreacion = new DateTime(2026, 5, 1).AddDays(i),
                    FechaModificacion = null
                });
            }
        }
        modelBuilder.Entity<Apunte>().HasData(apuntes);

        // D. SEMILLA DE POMODOROS (18 Mayo a 10 Junio, 4 a 6 hrs diarias)
        var pomodoros = new List<Pomodoro>();
        int pomodoroId = 1;

        DateTime fechaInicio = new DateTime(2026, 5, 18);
        DateTime fechaFin = new DateTime(2026, 6, 10);

        Random random = new Random(123); // Semilla fija para evitar cambios en migraciones posteriores

        var materiasWilson = materias.Where(m => m.IdUsuario == 1).ToList();
        var materiasKaren = materias.Where(m => m.IdUsuario == 2).ToList();

        for (DateTime fecha = fechaInicio; fecha <= fechaFin; fecha = fecha.AddDays(1))
        {
            if (fecha.DayOfWeek == DayOfWeek.Sunday) continue; // Descanso los domingos

            GenerarPomodorosDiarios(1, materiasWilson, fecha, ref pomodoroId, pomodoros, random);
            GenerarPomodorosDiarios(2, materiasKaren, fecha, ref pomodoroId, pomodoros, random);
        }
        modelBuilder.Entity<Pomodoro>().HasData(pomodoros);

        // E. SEMILLA DE PROGRESOS (Cálculo exacto basado en los pomodoros)
        var progresos = new List<Progreso>();
        int progresoId = 1;

        var pomodorosAgrupados = pomodoros.GroupBy(p => new { p.IdUsuario, p.IdMateria });
        foreach (var grupo in pomodorosAgrupados)
        {
            progresos.Add(new Progreso
            {
                IdProgreso = progresoId++,
                IdUsuario = grupo.Key.IdUsuario,
                IdMateria = grupo.Key.IdMateria,
                SegundosAcumulados = grupo.Sum(p => p.DuracionEstudio)
            });
        }
        modelBuilder.Entity<Progreso>().HasData(progresos);
    }

    // =========================================================
    // 3. MÉTODOS AUXILIARES
    // =========================================================
    private void GenerarPomodorosDiarios(int idUsuario, List<Materia> materiasUsuario, DateTime fecha, ref int pomodoroId, List<Pomodoro> pomodoros, Random random)
    {
        int cantidadSesiones = random.Next(10, 15); // Entre 4 y ~6 horas (cada sesión es 25+5 min)
        int minutosDelDia = 14 * 60; // Arrancan a estudiar a las 14:00

        for (int i = 0; i < cantidadSesiones; i++)
        {
            var materiaAleatoria = materiasUsuario[random.Next(materiasUsuario.Count)];

            pomodoros.Add(new Pomodoro
            {
                IdPomodoro = pomodoroId++,
                IdUsuario = idUsuario,
                IdMateria = materiaAleatoria.IdMateria,
                IdApunte = null,
                Fecha = fecha.AddMinutes(minutosDelDia),
                DuracionEstudio = 1500, // 25 minutos
                DuracionDescanso = 300, // 5 minutos
                EstadoFase = FasePomodoro.Completado
            });

            minutosDelDia += 30; // Salto temporal para el próximo pomodoro
        }
    }
}