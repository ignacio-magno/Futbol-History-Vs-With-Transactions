using Fulbo.Domain;
using Fulbo.Dto;

namespace Fulbo.Presenter;

public class EquipoPresenter
{
    private DatabaseContext Context;
    public EquipoPresenter(DatabaseContext context) => Context = context;

    public IEnumerable<EquipoDto> GetAll()
    {
        return Context.Equipos.ToList().Select(j => new EquipoDto(j));
    }
}