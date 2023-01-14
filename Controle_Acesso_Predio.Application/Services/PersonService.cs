using AutoMapper;
using Controle_Acesso_Predio.Application.DTO_s;
using Controle_Acesso_Predio.Application.Services.Interfaces;
using Controle_Acesso_Predio.Domain.Entities;
using Controle_Acesso_Predio.Domain.Interfaces;

namespace Controle_Acesso_Predio.Application.Services
{
    public class PersonService : IPersonService
    {
        private readonly IMapper _mapper;
        private readonly IPersonRepository _personRepository;

        public PersonService(IMapper mapper, IPersonRepository personRepository)
        {
            _mapper = mapper;
            _personRepository = personRepository;
        }

        public async Task<PersonDTO> CreateAsync(PersonDTO personDTO)
        {
            var person = _mapper.Map<Person>(personDTO);

            await _personRepository.CreateAsync(person);

            return _mapper.Map<PersonDTO>(person);
        }

        public async Task<IEnumerable<PersonDTO>> GetAllAsync()
        {
            var person = await _personRepository.GetAllAsync();
            if (person == null)
                return null;

            return _mapper.Map<IEnumerable<PersonDTO>>(person);
        }

        public async Task<PersonDTO> GetByDocument(string document)
        {
            if (document == null)
                return null;

            var person = await _personRepository.GetByDocument(document);

            return _mapper.Map<PersonDTO>(person);
        }
    }
}
