using Bogus;
using FluentAssertions;
using Fulbo;
using Fulbo.Domain;
using Fulbo.Dto;
using Fulbo.Presenter;

namespace TestProject1.Integration;

public class SessionUserTest
{
    [Test]
    public void RegisterNacho()
    {
        var user = "ignacio_magno";
        var pass = "123456";

        var s = new SessionPresenter(new DatabaseContext());
        s.Register(new UserDto(user), new CredentialsDto(pass));
    }

    [Test]
    public void CreateUserAndLogging()
    {
        var faker = new Faker();
        var nickName = faker.Person.UserName;

        var password = "123456";

        var s = new SessionPresenter(new DatabaseContext());
        s.Register(new UserDto(nickName), new CredentialsDto(password));

        s.Login(nickName, password).NickName.Should().Be(nickName);
    }

    [Test]
    public void NickNameNotRepeat()
    {
        var faker = new Faker();
        var nickName = faker.Person.UserName;

        using (var db = new DatabaseContext())
        {
            var s = new User(nickName);
            s.Session = new Session(nickName, "123456");
            db.Users.Add(s);
            db.SaveChanges();
        }

        using var db2 = new DatabaseContext();
        var sx = new User(nickName);
        sx.Session = new Session(nickName, "123456");
        db2.Users.Add(sx);
        var action = () => db2.SaveChanges();

        action.Should().Throw<Exception>();
    }

    public static UserDto User()
    {
        var faker = new Faker();
        var nickName = faker.Person.UserName;

        var password = "123456";

        var s = new SessionPresenter(new DatabaseContext());
        s.Register(new UserDto(nickName), new CredentialsDto(password));

        return s.Find(nickName);
    }
}