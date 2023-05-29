using Fulbo.Domain;
using Fulbo.Dto;

namespace Fulbo.Presenter;

public class SessionPresenter
{
    private DatabaseContext Context;

    public SessionPresenter(DatabaseContext context) => Context = context;

    public UserDto Login(string userName, string password)
    {
        var session = Context.Sessions.FirstOrDefault(s => s.UserName == userName);
        if (session == null) throw new Exception("Invalid credentials");
        if (!session.IsCorrectPass(password)) throw new Exception("Invalid credentials");

        var user = Context.Users.FirstOrDefault(u => u.SessionId == session.Id);
        if (user == null) throw new Exception("Invalid credentials");

        return new UserDto(user);
    }

    public UserDto Register(UserDto userDto, CredentialsDto credentialsDto)
    {
        var session = new Session(userDto.NickName, credentialsDto.Password);
        var user = new User(userDto.NickName);

        user.AddCredentials(session);
        Context.Users.Add(user);
        Context.SaveChanges();

        return new UserDto(user);
    }

    public UserDto Find(string nickName)
    {
        var user = Context.Users.FirstOrDefault(u => u.NickName == nickName);
        if (user == null) throw new Exception("User not found");

        return new UserDto(user);
    }

    public UserDto Find(int id)
    {
        return new UserDto(Context.Users.Find(id));
    }
}