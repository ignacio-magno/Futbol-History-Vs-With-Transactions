using Fulbo.Domain;

namespace Fulbo.Dto;

public class FutbolistaDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Num { get; set; }
    public string NombreCompleto => $"{Name} {LastName}";

    public FutbolistaDto(Futbolista futbolista)
    {
        Id = futbolista.Id;
        Name = futbolista.Name;
        LastName = futbolista.LastName;
        Num = futbolista.Num;
    }
}