using FluentAssertions;
using Fulbo.Domain;

namespace TestProject1.Unit;

public class SessionTest
{
    [Test]
    public void OnCreateSessionPasswordMustBeCrypted()
    {
        var session = new Session("ignacio_magno", "123456");
        session.Password.Should().NotBe("123456");
    }

    [Test]
    public void CorrectCheck()
    {
        var session = new Session("ignacio_magno", "123456");
        session.IsCorrectPass("123456").Should().BeTrue();
    }
}