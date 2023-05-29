namespace Fulbo.Domain.Jugadores;

public class JugadorVisitante : Jugador
{
    public JugadorVisitante(int idUser, int equipoId)
    {
        UserId = idUser;
        EquipoId = equipoId;
    }
    
    public JugadorVisitante()
    {
    }
}