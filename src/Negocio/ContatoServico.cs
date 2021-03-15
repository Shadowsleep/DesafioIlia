using Core.Entidade;
using Core.Interfaces.Infra;
using Negocio.Extensions;
using System.Collections.Generic;

namespace Negocio
{
    public class ContatoServico : IContatoServico
    {
        private readonly IRepositorio<Contato> _repositorioContato;

        public ContatoServico(IRepositorio<Contato> repositorioContato)
        {
            _repositorioContato = repositorioContato;
        }

        public void AtualizarContato(IEnumerable<Contato> contatos)
        {
            contatos.ForEach(x => _repositorioContato.Atualizar(x));
        }


        public void Dispose()
        {
            _repositorioContato?.Dispose();
        }
    }
}