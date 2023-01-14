using AutoMapper;
using Controle_Acesso_Predio.Application.DTO_s;
using Controle_Acesso_Predio.Application.Services.Interfaces;
using Controle_Acesso_Predio.Domain.Entities;
using Controle_Acesso_Predio.Domain.Interfaces;

namespace Controle_Acesso_Predio.Application.Services
{
    public class ControlPersonService : IControlPersonService
    {
        private readonly IControlPersonRepository _controlPersonRespository;
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;

        public ControlPersonService(IControlPersonRepository personRespository, IMapper mapper, IPersonRepository personRepository)
        {
            _controlPersonRespository = personRespository;
            _mapper = mapper;
            _personRepository = personRepository;
        }

        public async Task<ControlPersonDTO> CreateAsync(ControlPersonDTO controlPersonDTO)
        {
            if (controlPersonDTO == null)
                return null;

            var person = await _personRepository.GetByDocument(controlPersonDTO.Document);
            if(person.Document == controlPersonDTO.Document)
            {
                var result = _mapper.Map<ControlPerson>(controlPersonDTO);

                result.Document = person.Document;
                result.IdPerson = person.Id;
                result.Name = person.Name;
                result.Date = DateTime.Now;

                await _controlPersonRespository.CreateAsync(result);

                return _mapper.Map<ControlPersonDTO>(result);
            }

            return null;
        }

        public async Task<IEnumerable<ControlPersonDTO>> GetAllAsync()
        {
            var result = await _controlPersonRespository.GetAllAsync();
            if (result == null)
                return null;

            return _mapper.Map<IEnumerable<ControlPersonDTO>>(result);
        }
    }
}
