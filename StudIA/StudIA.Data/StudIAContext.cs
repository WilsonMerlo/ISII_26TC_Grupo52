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

        modelBuilder.Entity<Apunte>()
            .HasOne(a => a.Materia)
            .WithMany(m => m.Apuntes)
            .HasForeignKey(a => a.IdMateria);

        // --- SOLUCIÓN AL ERROR DE CASCADA ---
        // Evitamos que SQL Server se confunda al borrar un Usuario
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