using Controle_Acesso_Predio.Application.DTO_s;

namespace Controle_Acesso_Predio.Application.Services.Interfaces
{
    public interface IControlPersonService
    {
        Task<IEnumerable<ControlPersonDTO>> GetAllAsync();
        Task<ControlPersonDTO> CreateAsync(ControlPersonDTO controlPersonDTO);
    }
}
