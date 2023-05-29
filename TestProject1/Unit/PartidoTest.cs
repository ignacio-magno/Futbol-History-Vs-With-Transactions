using FluentAssertions;
using Fulbo.Domain;
using Fulbo.Domain.Jugadores;
using Moq;
using TestProject1.Provider;

namespace TestProject1.Unit;

public class PartidoTest
{
    [Test]
    public void MinutoOnAddGolMustBeBetween0and150()
    {
        var partido = new Partido();
        var mock = new Mock<IDataFutbol>();
        var action = () => partido.SetGol(TipoJugador.Local, 10, -1, mock.Object);
        var action2 = () => partido.SetGol(TipoJugador.Local, 10, 151, mock.Object);

        action.Should().Throw<Exception>();
        action2.Should().Throw<Exception>();
    }

    [Test]
    public void OnSetGol_IfPlayerNotIsForTeamError()
    {
        var jl = new JugadorLocal(1, 1);
        var jv = new JugadorVisitante(2, 2);
        var mock = new Mock<IDataFutbol>();
        mock.Setup(x => x.ExistPlayer(1, 10)).Returns(false);
        mock.Setup(x => x.ExistPlayer(1, 1)).Returns(true);

        var partido = new Partido(jl, jv);

        var action = () => partido.SetGol(TipoJugador.Local, 10, 20, mock.Object);
        action.Should().Throw<Exception>();


        action = () => partido.SetGol(TipoJugador.Local, 1, 20, mock.Object);
        action.Should().NotThrow<Exception>();
    }

    [Test]
    public void PartidoNotCanHaveSameUser()
    {
        var jl = new JugadorLocal(1, 1);
        var jv = new JugadorVisitante(1, 2);

        var action = () => new Partido(jl, jv);
        action.Should().Throw<Exception>();
    }
    
    [Test]
public void PartidoNotCanHaveSameTeam()
    {
        var jl = new JugadorLocal(1, 1);
        var jv = new JugadorVisitante(2, 1);

        var action = () => new Partido(jl, jv);
        action.Should().Throw<Exception>();
    }
}