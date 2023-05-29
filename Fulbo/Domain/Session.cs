namespace Fulbo.Domain;

public class Session
{
    public int Id { get; set; }

    public string UserName { get; set; }
    public string Password { get; set; }

    public Session(string name, string pass)
    {
        string salt = BCrypt.Net.BCrypt.GenerateSalt();
        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(pass, salt);

        UserName = name;
        Password = hashedPassword;
    }

    public Session()
    {
    }


    public bool IsCorrectPass(string pass)
    {
        return BCrypt.Net.BCrypt.Verify(pass, Password);
    }
}