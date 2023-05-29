using FluentAssertions;
using Fulbo.Domain;
using Fulbo.Domain.Jugadores;
using Moq;

namespace TestProject1.Unit;

public class UserAddPartidoTest
{
    [Test]
    public void AddPartidoWithGoles()
    {
        var jugadorLocal = new JugadorLocal(1, 2);
        var jugadorVisitante = new JugadorVisitante(2, 3);
        var partido = new Partido(jugadorLocal, jugadorVisitante);

        var idFutbolista = 3;
        var minuto = 30;
        
        var mock = new Mock<IDataFutbol>();
        mock.Setup(x => x.ExistPlayer(It.IsAny<int>(), It.IsAny<int>())).Returns(true);

        partido.SetGol(TipoJugador.Local, idFutbolista, minuto, mock.Object);
        partido.SetGol(TipoJugador.Visitante, idFutbolista, minuto, mock.Object);
        partido.SetGol(TipoJugador.Visitante, idFutbolista, minuto, mock.Object);
        partido.SetGol(TipoJugador.Visitante, idFutbolista, minuto, mock.Object);

        partido.GetGoles(TipoJugador.Local).Should().Be(1);
        partido.GetGoles(TipoJugador.Visitante).Should().Be(3);
        var ganador = partido.GetGanador();
        ganador.Should().Be(jugadorVisitante);
    }
}