using Controle_Acesso_Predio.Domain.Entities;

namespace Controle_Acesso_Predio.Domain.Interfaces
{
    public interface IControlPersonRepository
    {
        Task<IEnumerable<ControlPerson>> GetAllAsync();
        Task<ControlPerson> CreateAsync(ControlPerson controlPerson);
    }
}
