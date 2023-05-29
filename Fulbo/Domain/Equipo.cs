using System.ComponentModel.DataAnnotations.Schema;

namespace Fulbo.Domain;

public class Equipo
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public virtual ICollection<Futbolista> Futbolistas { get; set; } = new List<Futbolista>();

    public Equipo(string name)
    {
        Name = name;
    }

    public Equipo()
    {
    }

    public void AddFutbolista(Futbolista futbolista)
    {
        Futbolistas.Add(futbolista);
    }
}