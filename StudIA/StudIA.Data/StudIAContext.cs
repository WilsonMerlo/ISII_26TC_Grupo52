using Microsoft.EntityFrameworkCore;
using StudIA.Data.Entities;

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

        // Seed Data
        modelBuilder.Entity<Usuario>().HasData(
            new Usuario { IdUsuario = 1, Nombre = "Wilson Merlo", Correo = "wilson@test.com", Contrasena = "1234" }
        );

        modelBuilder.Entity<Materia>().HasData(
            new Materia { IdMateria = 1, IdUsuario = 1, NombreMateria = "Ingeniería de Software II", Descripcion = "Proyecto StudIA" },
            new Materia { IdMateria = 2, IdUsuario = 1, NombreMateria = "Cálculo", Descripcion = "Preparación de finales" },
            new Materia { IdMateria = 3, IdUsuario = 1, NombreMateria = "Estadística", Descripcion = "Modelos probabilísticos" }
        );
    }
}