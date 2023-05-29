using Fulbo.Domain;
using Fulbo.Domain.Jugadores;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Jugador = Fulbo.Domain.Jugadores.Jugador;

namespace Fulbo;

public class DatabaseContext : DbContext
{
    public DbSet<Session> Sessions { get; set; } = null!;
    public DbSet<Equipo> Equipos { get; set; }
    public DbSet<Partido> Partidos { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<JugadorLocal> JugadoresLocal { get; set; }
    public DbSet<JugadorVisitante> JugadoresVisitante { get; set; }
    public DbSet<Goles> Goles { get; set; }
    public DbSet<Futbolista> Futbolistas { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // User nickname is unique
        modelBuilder.Entity<User>()
            .HasIndex(u => u.NickName)
            .IsUnique();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseLazyLoadingProxies().UseSqlServer(
            "Server=192.168.1.142;Database=Fulbo;User Id=sa; Password=Admin1234;TrustServerCertificate=True;");
    }
}