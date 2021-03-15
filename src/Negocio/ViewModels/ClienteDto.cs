using System;
using System.Collections.Generic;

namespace Negocio.ViewModels
{
    public class ClienteDto
    {
        public ClienteDto()
        {
            Contatos = new List<ContatoDto>();
            Enderecos = new List<EnderecoDto>();
        }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public List<ContatoDto> Contatos { get; set; }

        public List<EnderecoDto> Enderecos { get; set; }
    }
}
