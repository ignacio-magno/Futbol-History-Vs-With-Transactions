using FluentAssertions;
using Fulbo;
using Fulbo.Dependencies;
using Fulbo.Domain;
using Fulbo.Domain.Jugadores;
using Fulbo.Presenter;
using Newtonsoft.Json;
using TestProject1.Provider;

namespace TestProject1.Integration;

public class PartidoPresenterTest
{
    [Test]
    public void METHOD()
    {
        var user = SessionUserTest.User();
        var user2 = SessionUserTest.User();
        var equipo1 = A.Equipo().Save();
        var equipo2 = A.Equipo().Save();

        var partido = new Partido(new JugadorLocal(user.Id, equipo1.Id),
            new JugadorVisitante(user2.Id, equipo2.Id));

        using (var db = new DatabaseContext())
        {
            partido.SetGol(TipoJugador.Local, equipo1.Futbolistas.First().Id, 10, new DataFutbol(db));
            partido.SetGol(TipoJugador.Local, equipo1.Futbolistas.First().Id, 20, new DataFutbol(db));
            partido.SetGol(TipoJugador.Visitante, equipo2.Futbolistas.First().Id, 30, new DataFutbol(db));
            partido.SetGol(TipoJugador.Visitante, equipo2.Futbolistas.First().Id, 50, new DataFutbol(db));
            partido.SetGol(TipoJugador.Visitante, equipo2.Futbolistas.First().Id, 40, new DataFutbol(db));

            var presenter = new PartidoPresenter(db);
            presenter.AddPartido(user.Id, partido);
        }

        using (var db = new DatabaseContext())
        {
            var presenter = new PartidoPresenter(db);
            var partidos = presenter.GetPartidosPendientes(user.Id);
            partidos.Count().Should().Be(1);

            partidos.First().Goles.Count().Should().Be(5);
            partidos.First().GetGanador().UserId.Should().Be(user2.Id);
        }
    }

    [Test]
    public void METHOD2()
    {
        var partido = new DatabaseContext().Partidos.Find(4);
        var js  = JsonConvert.SerializeObject(partido, Formatting.Indented,  new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        });
        Console.WriteLine(js);

    }
}