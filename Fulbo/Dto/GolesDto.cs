using Fulbo.Domain;

namespace Fulbo.Dto;

public class GolesDto
{
    public int Id { get; set; }
    public int Minute { get; set; }
    public string NombreFutbolista { get; set; }
    public int FutbolistaId { get; set; }
    public int Numero { get; set; }
    public TipoJugador TipoJugador { get; set; }

    public GolesDto(Goles goles)
    {
        Id = goles.Id;
        Minute = goles.Minute;
        NombreFutbolista = goles.Futbolista.Name;
        FutbolistaId = goles.FutbolistaId;
        Numero = goles.Futbolista.Num;
        TipoJugador = goles.TipoJugador;
    }
}