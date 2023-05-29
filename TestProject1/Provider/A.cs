using Bogus;
using Fulbo;
using Fulbo.Domain;

namespace TestProject1.Provider;

public static class A
{
    public static Equipo Equipo()
    {
        var faker = new Faker();

        var equipo = new Equipo(faker.Random.String2(10));
        for (int i = 0; i < 10; i++)
        {
            equipo.AddFutbolista(new Futbolista(faker.Random.String2(10), faker.Random.String2(10),
                faker.Random.Int(1, 99)));
        }

        return equipo;
    }

    public static Equipo Save(this Equipo equipo)
    {
        var db = new DatabaseContext();
        db.Equipos.Add(equipo);
        db.SaveChanges();
        return equipo;
    }
}