namespace Fulbo.Dto;

public class CredentialsDto
{
    public CredentialsDto(string password)
    {
        Password = password;
    }

    public string Password { get; set; }
}