using Core.Base;
using Core.Entidade.Enuns;
using System;

namespace Core.Entidade
{
    public class Contato : Entity
    {
        public TipoTelefonico TipoTelefonico { get; set; }
        public string Numero { get; set; }
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public void Validar()
        {
            AssertionConcern.ValidarSeNulo(TipoTelefonico, "Tipo telefonico Obrigatório");
            AssertionConcern.ValidarSeVazio(Numero, "Número Obrigatório");
        }
    }
}
