using Controle_Acesso_Predio.Domain.Entities;

namespace Controle_Acesso_Predio.Domain.Interfaces
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> GetAllAsync();
        Task<Person> CreateAsync(Person person);
        Task<Person> GetByDocument(string document);
    }
}
