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
        // Configuramos las PKs (Asegurate de que estén TODAS estas líneas)
        modelBuilder.Entity<Usuario>().HasKey(u => u.IdUsuario);
        modelBuilder.Entity<Materia>().HasKey(m => m.IdMateria);
        modelBuilder.Entity<Apunte>().HasKey(a => a.IdApunte);
        modelBuilder.Entity<Pomodoro>().HasKey(p => p.IdPomodoro);
        modelBuilder.Entity<Progreso>().HasKey(p => p.IdProgreso);

        // Relación Materia -> Usuario
        modelBuilder.Entity<Materia>()
            .HasOne(m => m.Usuario)
            .WithMany(u => u.Materias)
            .HasForeignKey(m => m.IdUsuario);

        // --- SEED DATA ---
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