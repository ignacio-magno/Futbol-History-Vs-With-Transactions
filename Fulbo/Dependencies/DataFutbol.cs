using Fulbo.Domain;

namespace Fulbo.Dependencies;

public class DataFutbol : IDataFutbol
{
    private readonly DatabaseContext _db;

    public DataFutbol(DatabaseContext db)
    {
        _db = db;
    }

    public bool ExistPlayer(int equipoId, int idFutbolista)
    {
        var equipo = _db.Equipos.Find(equipoId);
        if (equipo == null) throw new Exception("Equipo no encontrado");
        return equipo.Futbolistas.Any(x => x.Id == idFutbolista);
    }
}