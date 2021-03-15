using System;

namespace Negocio.ViewModels
{
    public class EnderecoDto
    {
        public Guid Id { get; set; }
        public Guid ClienteId { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string CodigoPostal { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
    }
}