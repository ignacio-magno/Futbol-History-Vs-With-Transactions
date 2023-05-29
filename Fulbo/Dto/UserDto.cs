using Fulbo.Domain;
using Fulbo.Domain.Jugadores;

namespace Fulbo.Dto;

public class UserDto
{
    public UserDto(string nickName)
    {
        NickName = nickName;
    }

    public UserDto(User sessionUser)
    {
        NickName = sessionUser.NickName;
        Id = sessionUser.Id;
    }

    public string NickName { get; set; }
    public int Id { get; set; }
}