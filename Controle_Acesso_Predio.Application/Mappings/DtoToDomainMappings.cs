using AutoMapper;
using Controle_Acesso_Predio.Application.DTO_s;
using Controle_Acesso_Predio.Domain.Entities;

namespace Controle_Acesso_Predio.Application.Mappings
{
    public class DtoToDomainMappings : Profile
    {
        public DtoToDomainMappings()
        {
            CreateMap<PersonDTO, Person>();
            CreateMap<ControlPersonDTO, ControlPerson>();
        }
    }
}
