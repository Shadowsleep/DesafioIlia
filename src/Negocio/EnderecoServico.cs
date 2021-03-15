using Core.Entidade;
using Core.Interfaces.Infra;
using Negocio.Extensions;
using System.Collections.Generic;

namespace Negocio
{
    public class EnderecoServico : IEnderecoServico
    {
        private readonly IRepositorio<Endereco> _repositorioEndereco;

        public EnderecoServico(IRepositorio<Endereco> repositorioEndereco)
        {
            _repositorioEndereco = repositorioEndereco;
        }

        public void AdicionarEndereco(IEnumerable<Endereco> enderecos)
        {
            enderecos.ForEach(x => _repositorioEndereco.Adicionar(x));

        }

        public void AtualizarEndereco(IEnumerable<Endereco> enderecos)
        {
            enderecos.ForEach(x => _repositorioEndereco.Atualizar(x));
        }

        public void Dispose()
        {
            _repositorioEndereco?.Dispose();
        }
    }
}
