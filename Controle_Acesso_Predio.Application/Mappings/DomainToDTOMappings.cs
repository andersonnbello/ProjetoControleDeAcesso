using AutoMapper;
using Controle_Acesso_Predio.Application.DTO_s;
using Controle_Acesso_Predio.Domain.Entities;

namespace Controle_Acesso_Predio.Application.Mappings
{
    public class DomainToDTOMappings : Profile
    {
        public DomainToDTOMappings()
        {
            CreateMap<Person, PersonDTO>();
            CreateMap<ControlPerson, ControlPersonDTO>();
        }
    }
}
