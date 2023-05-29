using Fulbo.Domain;
using Fulbo.Dto;

namespace Fulbo.Presenter;

public class PartidoPresenter
{
    private DatabaseContext _context;

    public PartidoPresenter(DatabaseContext context) => _context = context;

    public IEnumerable<PartidoDto> GetPartidos(int idUser)
    {
        var partidos = Get(idUser);
        return partidos.Where(j => j.AllFirmado()).Select(j => new PartidoDto(j));
    }

    public IEnumerable<PartidoDto> GetPartidosPendientes(int idUser)
    {
        var partidos = Get(idUser);
        return partidos.Where(j => !j.UserSigned(idUser)).Select(j => new PartidoDto(j));
    }

    public IEnumerable<Partido> Get(int idUser)
    {
        foreach (var jugadorLocal in _context.JugadoresLocal.Where(x => x.UserId == idUser).ToList())
        {
            yield return jugadorLocal.Partido;
        }

        foreach (var jugadorVisitante in _context.JugadoresVisitante.Where(x => x.UserId == idUser).ToList())
        {
            yield return jugadorVisitante.Partido;
        }
    }

    public void AddPartido(int idUser, Partido partido)
    {
        partido.Firmar(idUser);
        _context.Partidos.Add(partido);
        _context.SaveChanges();
    }

    public void SignPartido(int selectedPartidoId, int sessionId)
    {
        var partido = _context.Partidos.Find(selectedPartidoId);
        partido.Firmar(sessionId);
        _context.SaveChanges();
    }
}