namespace Fulbo.Domain.Jugadores;

public abstract class Jugador
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }
    public int PartidoId { get; set; }
    public virtual Partido Partido { get; set; }

    public int EquipoId { get; set; }
    public virtual Equipo Equipo { get; set; }
    public bool Firmado { get; set; }

    public void Firmar()
    {
        Firmado = true;
    }
}