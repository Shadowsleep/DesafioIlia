using Core.Interfaces.Infra;
using Infra.Contexto;
using Infra.Repositorio;
using Microsoft.Extensions.DependencyInjection;
using Negocio;

namespace Aplicacao.Setup
{
    public static class InjecaoDeDependencia
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            //Repositorio
            services.AddScoped<ContextoBancoDeDados>();
            services.AddScoped(typeof(IRepositorio<>), typeof(RepositorioBase<>));

            //Negocio
            services.AddScoped<IClienteServico, ClienteServico>();
            services.AddScoped<IContatoServico, ContatoServico>();
            services.AddScoped<IEnderecoServico, EnderecoServico>();
        }
    }
}
