namespace Fulbo.Domain;

public enum TipoJugador
{
    Local = 1,
    Visitante = 2
}

public static class Extensions
{
    public static int EstadoEquipoToInt(this TipoJugador tipoJugador)
    {
        return tipoJugador == TipoJugador.Local ? 1 : 2;  
    }
}