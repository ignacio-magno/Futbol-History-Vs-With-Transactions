using Fulbo.Domain;
using Jugador = Fulbo.Domain.Jugadores.Jugador;

namespace EmptyBlazorApp1.Domain;

public class DataGol
{
    public TipoJugador TipoJugador { get; set; }
    public int IdFutbolista { get; set; }
    public int Minuto { get; set; }
}