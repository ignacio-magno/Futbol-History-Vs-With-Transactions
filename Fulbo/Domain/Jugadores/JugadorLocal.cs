namespace Fulbo.Domain.Jugadores;

public class JugadorLocal: Jugador
{
    public JugadorLocal(int userId, int equipoId)
    {
        UserId = userId;
        EquipoId = equipoId;
    }
    public JugadorLocal()
    {
    }
}