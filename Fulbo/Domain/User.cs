namespace Fulbo.Domain;

public class User
{
    public int Id { get; set; }

    public string NickName { get; set; }

    public virtual Session? Session { get; set; }
    public int SessionId { get; set; }

    public User(string nickName)
    {
        NickName = nickName;
    }

    public void AddCredentials(Session session)
    {
        Session = session;
    }
}