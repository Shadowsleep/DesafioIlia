using AutoMapper;
using Core.Entidade;
using Negocio.ViewModels;

namespace Negocio.Mapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClienteDto, Cliente>();
            CreateMap<EnderecoDto, Endereco>();
            CreateMap<ContatoDto, Contato>();
        }
    }
}
