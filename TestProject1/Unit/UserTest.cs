using FluentAssertions;
using Fulbo.Domain;

namespace TestProject1.Unit;

public class UserTest
{
    [Test]
    public void CorrectLog()
    {
        var user = new User("ignacio_magno");
        user.AddCredentials(new Session("ignacio_magno", "123456"));
    }

}