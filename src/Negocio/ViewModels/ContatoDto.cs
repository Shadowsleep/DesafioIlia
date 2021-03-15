using Core.Entidade.Enuns;
using System;

namespace Negocio.ViewModels
{
    public class ContatoDto
    {
        public Guid Id { get; set; }
        public Guid ClienteId { get; set; }
        public TipoTelefonico TipoTelefonico { get; set; }
        public string Numero { get; set; }
    }
}