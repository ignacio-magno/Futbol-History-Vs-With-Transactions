using Bogus;
using FluentAssertions;
using Fulbo;
using Fulbo.Domain;
using Fulbo.Domain.Jugadores;
using Moq;
using TestProject1.Provider;

namespace TestProject1.Integration;

public class UserRegisterPartidoTest
{
    [Test]
    public void ObtainPartidosPlayedFromUser()
    {
        var user = SessionUserTest.User();
        var equipo1 = A.Equipo().Save();
        var equipo2 = A.Equipo().Save();

        for (int i = 0; i < 10; i++)
        {
            var createPartido = () =>
            {
                var faker = new Faker();
                if (faker.Random.Bool())
                    return new Partido(new JugadorLocal(user.Id, equipo1.Id),
                        new JugadorVisitante(SessionUserTest.User().Id, equipo2.Id));
                return new Partido(new JugadorLocal(SessionUserTest.User().Id, equipo1.Id),
                    new JugadorVisitante(user.Id, equipo2.Id));
            };

            using var db = new DatabaseContext();
            db.Partidos.Add(createPartido());
            db.SaveChanges();
        }

        using (var db = new DatabaseContext())
        {
            var count = 0;

            count += db.JugadoresLocal.Count(x => x.UserId == user.Id);
            count += db.JugadoresVisitante.Count(x => x.UserId == user.Id);
            count.Should().Be(10);

            db.Partidos
                .Where(x => x.JugadorLocal.EquipoId == equipo1.Id).Count().Should().Be(10);

            db.Partidos
                .Where(x => x.JugadorVisitante.EquipoId == equipo2.Id).Count().Should().Be(10);
        }
    }

    [Test]
    public void CorrectFutbolistaGoles()
    {
        var equipo = A.Equipo().Save();
        var equipo2 = A.Equipo().Save();

        var futbolista = equipo.Futbolistas.First();

        var partido = new Partido(
            new JugadorLocal(SessionUserTest.User().Id, equipo.Id),
            new JugadorVisitante(SessionUserTest.User().Id, equipo2.Id));

        var mock = new Mock<IDataFutbol>();
        mock.Setup(x => x.ExistPlayer(It.IsAny<int>(), It.IsAny<int>())).Returns(true);

        partido.SetGol(TipoJugador.Local, futbolista.Id, 10, mock.Object);
        partido.SetGol(TipoJugador.Local, futbolista.Id, 20, mock.Object);
        partido.SetGol(TipoJugador.Local, futbolista.Id, 30, mock.Object);
        partido.SetGol(TipoJugador.Local, futbolista.Id, 40, mock.Object);

        using (var db = new DatabaseContext())
        {
            db.Partidos.Add(partido);
            db.SaveChanges();
        }

        using (var db = new DatabaseContext())
        {
            db.Goles.Where(j => j.FutbolistaId == futbolista.Id).Count().Should().Be(4);
        }
    }
}