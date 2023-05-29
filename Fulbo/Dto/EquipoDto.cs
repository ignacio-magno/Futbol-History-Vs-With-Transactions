using Fulbo.Domain;

namespace Fulbo.Dto;

public class EquipoDto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public IEnumerable<FutbolistaDto> Jugadores { get; set; }

    public EquipoDto(Equipo equipo)
    {
        Id = equipo.Id;
        Nombre = equipo.Name;
        Jugadores = equipo.Futbolistas.Select(j => new FutbolistaDto(j));
    }
}