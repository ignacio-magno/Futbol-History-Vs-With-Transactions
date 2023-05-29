namespace Fulbo.Domain;

public class Goles
{
    public Goles(TipoJugador tipoJugador, int futbolistaId, int minute)
    {
        FutbolistaId = futbolistaId;
        Minute = minute;
        TipoJugador = tipoJugador; 
    }

    public int Id { get; set; }
    public int Minute { get; set; }

    public virtual Futbolista Futbolista { get; set; }
    public int FutbolistaId { get; set; }
    public TipoJugador TipoJugador { get; set; }
}