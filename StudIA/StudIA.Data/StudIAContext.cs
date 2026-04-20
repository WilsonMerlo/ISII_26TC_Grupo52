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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configuramos las PKs por convención o manualmente si es necesario
        modelBuilder.Entity<Usuario>().HasKey(u => u.IdUsuario);
        modelBuilder.Entity<Materia>().HasKey(m => m.IdMateria);
        modelBuilder.Entity<Apunte>().HasKey(a => a.IdApunte);
        modelBuilder.Entity<Pomodoro>().HasKey(p => p.IdPomodoro);
    }
}