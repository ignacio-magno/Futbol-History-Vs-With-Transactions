using Fulbo.Domain.Jugadores;
using Fulbo.Dto;

namespace Fulbo.Domain;

public class Partido
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; } = DateTime.Now;
    public virtual JugadorLocal JugadorLocal { get; set; }
    public virtual JugadorVisitante JugadorVisitante { get; set; }
    public virtual ICollection<Goles> Goles { get; set; } = new List<Goles>();

    public Partido(JugadorLocal jugadorLocal, JugadorVisitante jugadorVisitante)
    {
        if (jugadorLocal.EquipoId == jugadorVisitante.EquipoId)
            throw new Exception("El partido no puede ser entre el mismo equipo");
        if (jugadorLocal.UserId == jugadorVisitante.UserId)
            throw new Exception("El partido no puede ser entre el mismo jugador");
        JugadorLocal = jugadorLocal;
        JugadorVisitante = jugadorVisitante;
    }

    public Partido()
    {
    }

    public void SetGol(TipoJugador tipoJugador, int idFutbolista, int minuto, IDataFutbol _dataFutbol)
    {
        if (minuto < 0 || minuto > 150)
            throw new Exception("Minuto invalido");

        if (!_dataFutbol.ExistPlayer(GetJugador(tipoJugador).EquipoId, idFutbolista))
        {
            throw new Exception("Futbolista no pertenece al equipo");
        }

        Goles.Add(new Goles(tipoJugador, idFutbolista, minuto));
    }

    public Jugador GetJugador(TipoJugador tipoJugador) => tipoJugador switch
    {
        TipoJugador.Local => JugadorLocal,
        TipoJugador.Visitante => JugadorVisitante,
        _ => throw new Exception("Tipo de jugador invalido")
    };

    public int GetGoles(TipoJugador tipoJugador)
    {
        return Goles.Count(x => x.TipoJugador == tipoJugador);
    }

    public Jugador GetGanador()
    {
        var golesLocal = GetGoles(TipoJugador.Local);
        var golesVisitante = GetGoles(TipoJugador.Visitante);

        if (golesLocal > golesVisitante)
            return JugadorLocal;

        if (golesLocal < golesVisitante)
            return JugadorVisitante;

        throw new Exception("No hay ganador");
    }

    public void Firmar(int idUser)
    {
        if (JugadorLocal.UserId == idUser)
            JugadorLocal.Firmar();

        if (JugadorVisitante.UserId == idUser)
            JugadorVisitante.Firmar();
    }

    public bool AllFirmado()
    {
        return JugadorLocal.Firmado && JugadorVisitante.Firmado;
    }

    public bool UserSigned(int idUser)
    {
        var jugador = JugadorLocal.UserId == idUser ? (Jugador)JugadorLocal :
            JugadorVisitante.UserId == idUser ? JugadorVisitante : null;
        
        return jugador?.Firmado ?? false;
    }
}