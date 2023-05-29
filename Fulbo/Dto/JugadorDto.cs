using Fulbo.Domain.Jugadores;

namespace Fulbo.Dto;

public class JugadorDto
{
    public string NickName { get; set; }
    public int UserId { get; set; }
    public string EquipoId { get; set; }
    public string EquipoSeleccionado { get; set; }

    public JugadorDto(Jugador partidoJugadorLocal)
    {
        NickName = partidoJugadorLocal.User.NickName;
        EquipoId = partidoJugadorLocal.EquipoId.ToString();
        EquipoSeleccionado = partidoJugadorLocal.Equipo.Name;
        UserId = partidoJugadorLocal.UserId;
    }
}