using Fulbo.Dto;

namespace Fulbo.Presenter;

public class UserPresenter
{
    private DatabaseContext Context;
    
    public UserPresenter(DatabaseContext context) => Context = context;

    public void Register()
    {
        
    }

    public IEnumerable<UserDto> GetAll()
    {
        return Context.Users.Select(u => new UserDto(u));
    }
}