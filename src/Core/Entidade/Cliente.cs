using Core.Base;
using System.Collections.Generic;

namespace Core.Entidade
{
    public class Cliente : Entity
    {
        public Cliente()
        {
            Contatos = new List<Contato>();
            Enderecos = new List<Endereco>();
        }

        public string Nome { get; set; }
        public string Email { get; set; }

        public List<Contato> Contatos { get; set; }

        public List<Endereco> Enderecos { get; set; }

        public void Validar()
        {
            AssertionConcern.ValidarSeVazio(Nome, "O nome não pode estar vazio");
            AssertionConcern.ValidarSeVazio(Email, "O Email não pode estar vazio");
        }
    }
}
