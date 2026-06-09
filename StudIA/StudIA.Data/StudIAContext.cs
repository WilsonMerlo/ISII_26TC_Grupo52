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
        // 1. REGLAS DE RELACIONES Y BORRADO
        // =========================================================

        // Usuarios -> Materias: tiene (CASCADE)
        modelBuilder.Entity<Materia>()
            .HasOne(m => m.Usuario)
            .WithMany(u => u.Materias)
            .HasForeignKey(m => m.IdUsuario)
            .OnDelete(DeleteBehavior.Cascade);

        // Usuarios -> Progresos: posee (RESTRICT)
        modelBuilder.Entity<Progreso>()
            .HasOne(p => p.Usuario)
            .WithMany()
            .HasForeignKey(p => p.IdUsuario)
            .OnDelete(DeleteBehavior.Restrict);

        // Usuarios -> Pomodoros: registra (RESTRICT)
        modelBuilder.Entity<Pomodoro>()
            .HasOne(p => p.Usuario)
            .WithMany()
            .HasForeignKey(p => p.IdUsuario)
            .OnDelete(DeleteBehavior.Restrict);

        // Materias -> Progresos: mide (CASCADE)
        modelBuilder.Entity<Progreso>()
            .HasOne(p => p.Materia)
            .WithMany()
            .HasForeignKey(p => p.IdMateria)
            .OnDelete(DeleteBehavior.Cascade);

        // Materias -> Apuntes: contiene (CASCADE)
        modelBuilder.Entity<Apunte>()
            .HasOne(a => a.Materia)
            .WithMany(m => m.Apuntes)
            .HasForeignKey(a => a.IdMateria)
            .OnDelete(DeleteBehavior.Cascade);

        // Materias -> Pomodoros: acumula (SET NULL) - Configurado para múltiples rutas
        modelBuilder.Entity<Pomodoro>()
            .HasOne(p => p.Materia)
            .WithMany()
            .HasForeignKey(p => p.IdMateria)
            .OnDelete(DeleteBehavior.ClientSetNull);

        // Apuntes -> Pomodoros: enfoca (SET NULL) - Configurado para múltiples rutas
        modelBuilder.Entity<Pomodoro>()
            .HasOne(p => p.Apunte)
            .WithMany(a => a.Pomodoros)
            .HasForeignKey(p => p.IdApunte)
            .OnDelete(DeleteBehavior.ClientSetNull);
        // =========================================================
        // 2. GENERACIÓN DE SEED DATA
        // =========================================================

        var usuarios = new List<Usuario>
        {
            new Usuario { IdUsuario = 1, Nombre = "Wilson Merlo", Correo = "wilson@test.com", Contrasena = "1234" },
            new Usuario { IdUsuario = 2, Nombre = "Karen", Correo = "karen@test.com", Contrasena = "1234" }
        };
        modelBuilder.Entity<Usuario>().HasData(usuarios);

        var materias = new List<Materia>
        {
            new Materia { IdMateria = 1, IdUsuario = 1, NombreMateria = "Ingeniería de Software II", Descripcion = "Proyecto StudIA" },
            new Materia { IdMateria = 2, IdUsuario = 1, NombreMateria = "Cálculo", Descripcion = "Preparación de finales" },
            new Materia { IdMateria = 3, IdUsuario = 1, NombreMateria = "Estadística", Descripcion = "Modelos probabilísticos" },
            new Materia { IdMateria = 4, IdUsuario = 1, NombreMateria = "Sistemas Operativos", Descripcion = "Concurrencia y memoria" },
            new Materia { IdMateria = 5, IdUsuario = 1, NombreMateria = "Bases de Datos", Descripcion = "SQL y NoSQL" },
            new Materia { IdMateria = 6, IdUsuario = 2, NombreMateria = "Programación Web", Descripcion = "React y Node.js" },
            new Materia { IdMateria = 7, IdUsuario = 2, NombreMateria = "Arquitectura de Software", Descripcion = "Patrones de diseño" },
            new Materia { IdMateria = 8, IdUsuario = 2, NombreMateria = "Matemática Discreta", Descripcion = "Grafos y lógica" },
            new Materia { IdMateria = 9, IdUsuario = 2, NombreMateria = "Redes de Computadoras", Descripcion = "Modelo OSI y TCP/IP" },
            new Materia { IdMateria = 10, IdUsuario = 2, NombreMateria = "Gestión de Proyectos", Descripcion = "Metodologías Ágiles" }
        };
        modelBuilder.Entity<Materia>().HasData(materias);

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

        var pomodoros = new List<Pomodoro>();
        int pomodoroId = 1;

        DateTime fechaInicio = new DateTime(2026, 5, 18);
        DateTime fechaFin = new DateTime(2026, 6, 10);

        Random random = new Random(123);

        var materiasWilson = materias.Where(m => m.IdUsuario == 1).ToList();
        var materiasKaren = materias.Where(m => m.IdUsuario == 2).ToList();
        var apuntesWilson = apuntes.Where(a => materiasWilson.Select(m => m.IdMateria).Contains(a.IdMateria)).ToList();
        var apuntesKaren = apuntes.Where(a => materiasKaren.Select(m => m.IdMateria).Contains(a.IdMateria)).ToList();

        for (DateTime fecha = fechaInicio; fecha <= fechaFin; fecha = fecha.AddDays(1))
        {
            if (fecha.DayOfWeek == DayOfWeek.Sunday) continue;

            GenerarPomodorosDiarios(1, materiasWilson, apuntesWilson, fecha, ref pomodoroId, pomodoros, random);
            GenerarPomodorosDiarios(2, materiasKaren, apuntesKaren, fecha, ref pomodoroId, pomodoros, random);
        }
        modelBuilder.Entity<Pomodoro>().HasData(pomodoros);

        var progresos = new List<Progreso>();
        int progresoId = 1;

        var pomodorosAgrupados = pomodoros
            .Where(p => p.IdMateria != null)
            .GroupBy(p => new { p.IdUsuario, IdMateria = p.IdMateria.Value });

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
    private void GenerarPomodorosDiarios(int idUsuario, List<Materia> materiasUsuario, List<Apunte> apuntesUsuario, DateTime fecha, ref int pomodoroId, List<Pomodoro> pomodoros, Random random)
    {
        int cantidadSesiones = random.Next(10, 15);
        int minutosDelDia = 14 * 60;

        for (int i = 0; i < cantidadSesiones; i++)
        {
            int tipo = random.Next(100);
            int? idMateriaSeleccionada = null;
            int? idApunteSeleccionado = null;

            if (tipo >= 20)
            {
                var materiaAleatoria = materiasUsuario[random.Next(materiasUsuario.Count)];
                idMateriaSeleccionada = materiaAleatoria.IdMateria;

                if (tipo >= 60)
                {
                    var apuntesMateria = apuntesUsuario.Where(a => a.IdMateria == idMateriaSeleccionada).ToList();
                    if (apuntesMateria.Any())
                    {
                        idApunteSeleccionado = apuntesMateria[random.Next(apuntesMateria.Count)].IdApunte;
                    }
                }
            }

            pomodoros.Add(new Pomodoro
            {
                IdPomodoro = pomodoroId++,
                IdUsuario = idUsuario,
                IdMateria = idMateriaSeleccionada,
                IdApunte = idApunteSeleccionado,
                Fecha = fecha.AddMinutes(minutosDelDia),
                DuracionEstudio = 1500,
                DuracionDescanso = 300,
                EstadoFase = FasePomodoro.Completado
            });

            minutosDelDia += 30;
        }
    }
}