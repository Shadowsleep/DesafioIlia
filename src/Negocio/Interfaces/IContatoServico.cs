using Core.Entidade;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public interface IContatoServico :IDisposable
    {
        void AtualizarContato(IEnumerable<Contato> contatos);
    }
}
