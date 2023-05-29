using Fulbo.Domain;

namespace Fulbo.Dto;

public class PartidoDto
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; } = DateTime.Now;
    public JugadorDto JugadorLocal { get; set; }
    public JugadorDto JugadorVisitante { get; set; }
    public virtual ICollection<GolesDto> Goles { get; set; } = new List<GolesDto>();

    public PartidoDto(Partido partido)
    {
        Id = partido.Id;
        Fecha = partido.Fecha;
        JugadorLocal = new JugadorDto(partido.JugadorLocal);
        JugadorVisitante = new JugadorDto(partido.JugadorVisitante);
        Goles = partido.Goles.Select(x => new GolesDto(x)).ToList();
    }

    public string Ganador
    {
        get
        {
            var golesLocal = Goles.Where(x => x.TipoJugador == TipoJugador.Local).Count();
            var golesVisitante = Goles.Where(x => x.TipoJugador == TipoJugador.Visitante).Count();
            var lov = golesLocal > golesVisitante ? "L" : "V";

            return $"{lov} {golesLocal}/{golesVisitante}";
        }
    }

    public JugadorDto GetGanador()
    {
        var golesLocal = Goles.Where(x => x.TipoJugador == TipoJugador.Local).Count();
        var golesVisitante = Goles.Where(x => x.TipoJugador == TipoJugador.Visitante).Count();

        return golesLocal > golesVisitante ? JugadorLocal : JugadorVisitante;
    }
}