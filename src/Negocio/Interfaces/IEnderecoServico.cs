using Core.Entidade;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public interface IEnderecoServico : IDisposable
    {
        void AdicionarEndereco(IEnumerable<Endereco> enderecos);
        void AtualizarEndereco(IEnumerable<Endereco> enderecos);
    }
}
