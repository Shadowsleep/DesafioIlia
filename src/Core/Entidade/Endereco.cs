using Core.Base;
using System;

namespace Core.Entidade
{
    public class Endereco : Entity
    {
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string CodigoPostal { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public Guid  ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public void Validar()
        {
            AssertionConcern.ValidarSeVazio(Rua, "Rua Obrigatório");
            AssertionConcern.ValidarSeVazio(Numero, "Número Obrigatório");
            AssertionConcern.ValidarSeVazio(CodigoPostal, "Código Postal Obrigatório");
            AssertionConcern.ValidarSeVazio(Cidade, "Cidade Obrigatório");
            AssertionConcern.ValidarSeVazio(Estado, "Estado Obrigatório");
            AssertionConcern.ValidarSeVazio(Pais, "País Obrigatório");

        }
    }
}