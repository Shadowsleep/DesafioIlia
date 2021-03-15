using AutoMapper;
using Core.Entidade;
using Negocio.ViewModels;

namespace Negocio.Mapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Cliente, ClienteDto>();
            CreateMap<Endereco, EnderecoDto>();
            CreateMap<Contato, ContatoDto>();
        }
    }
}
