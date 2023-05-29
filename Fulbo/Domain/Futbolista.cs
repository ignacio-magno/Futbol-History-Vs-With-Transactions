namespace Fulbo.Domain;

public class Futbolista
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Num { get; set; }
    
    public Futbolista(string name, string lastName, int num)
    {
        Name = name;
        LastName = lastName;
        Num = num;
    }
}