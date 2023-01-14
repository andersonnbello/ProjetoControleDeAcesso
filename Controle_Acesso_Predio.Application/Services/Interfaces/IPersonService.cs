using Controle_Acesso_Predio.Application.DTO_s;

namespace Controle_Acesso_Predio.Application.Services.Interfaces
{
    public interface IPersonService
    {
        Task<IEnumerable<PersonDTO>> GetAllAsync();
        Task <PersonDTO> CreateAsync(PersonDTO personDTO);
        Task<PersonDTO> GetByDocument(string document);
    }
}
