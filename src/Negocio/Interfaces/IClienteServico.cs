using Negocio.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Negocio
{
    public interface IClienteServico : IDisposable
    {
        bool AdicionarCliente(ClienteDto clienteViewModel);
        bool EditarCliente(ClienteDto clienteViewModel);
        Task<bool> ExcluirCliente(Guid ClienteGuid);
        Task<ClienteDto> BuscarCliente(Guid ClienteGuid);
        Task<IEnumerable<ClienteDto>> ListarCliente();
    }
}
