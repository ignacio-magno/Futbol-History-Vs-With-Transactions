namespace Fulbo.Domain;

public class DataEquipo
{
    public int Id { get; set; }
    public int EquipoId { get; set; }
    public virtual Equipo Equipo { get; set; }
    public TipoJugador TipoJugador { get; set; }

    public int PartidoId { get; set; }
    public virtual Partido Partido { get; set; }

    public DataEquipo(int equipoId, TipoJugador tipoJugador)
    {
        EquipoId = equipoId;
        TipoJugador = tipoJugador;
    }

    public DataEquipo()
    {
    }
}