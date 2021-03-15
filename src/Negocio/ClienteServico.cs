using AutoMapper;
using Core.Entidade;
using Core.Interfaces.Infra;
using Negocio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteServico : IClienteServico
    {
        private readonly IMapper _mapper;
        private readonly IRepositorio<Cliente> _repositorio;
        private readonly IContatoServico _contatoServico;
        private readonly IEnderecoServico _enderecoServico;

        public ClienteServico(IMapper mapper, IRepositorio<Cliente> repositorio, IContatoServico contatoServico, IEnderecoServico enderecoServico)
        {
            _mapper = mapper;
            _repositorio = repositorio;
            _contatoServico = contatoServico;
            _enderecoServico = enderecoServico;
        }

        public bool AdicionarCliente(ClienteDto clienteViewModel)
        {
            try
            {
                var cliente = _mapper.Map<Cliente>(clienteViewModel);
                _repositorio.Adicionar(cliente);

                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message, ex.InnerException);
            }
        }

        public async Task<ClienteDto> BuscarCliente(Guid ClienteGuid)
        {
            var include = new List<string> { "Contatos", "Enderecos" };
            var cliente = await _repositorio.BuscarPorId(ClienteGuid, include);
            return _mapper.Map<ClienteDto>(cliente);
        }

        public async Task<bool> ExcluirCliente(Guid ClienteGuid)
        {
            try
            {
                var include = new List<string> { "Contatos", "Enderecos" };
                var cliente = await _repositorio.BuscarPorId(ClienteGuid, include);
                _repositorio.Deletar(cliente);
                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message, ex.InnerException);
            }
        }


        public async Task<IEnumerable<ClienteDto>> ListarCliente()
        {
            var include = new List<string> { "Contatos", "Enderecos" };
            return _mapper.Map<IEnumerable<ClienteDto>>(await _repositorio.BuscarTodos(include));
        }

        public bool EditarCliente(ClienteDto clienteViewModel)
        {
            try
            {
                var cliente = _mapper.Map<Cliente>(clienteViewModel);
                _enderecoServico.AtualizarEndereco(cliente.Enderecos.Where(x => x.Id != Guid.Empty));
                _enderecoServico.AdicionarEndereco(cliente.Enderecos.Where(x => x.Id == Guid.Empty));
                _contatoServico.AtualizarContato(cliente.Contatos.Where(x => x.Id != Guid.Empty));
                _repositorio.Atualizar(cliente);

                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message, ex.InnerException);
            }
        }

        public void Dispose()
        {
            _repositorio?.Dispose();

        }
    }
}