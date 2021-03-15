using Microsoft.AspNetCore.Mvc;
using Negocio;
using Negocio.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Aplicacao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteServico _business;

        public ClienteController(IClienteServico business)
        {
            this._business = business;
        }

        [Route("Listar")]
        [HttpGet]
        public async Task<IEnumerable<ClienteDto>> Listar()
        {
            return await _business.ListarCliente();
        }

        [HttpPost]
        public IActionResult Post(ClienteDto cliente)
        {
            _business.AdicionarCliente(cliente);
            return Ok("Objeto Salvo");
        }

        [HttpPut]
        public IActionResult Put(ClienteDto cliente)
        {
            _business.EditarCliente(cliente);
            return Ok("Objeto atualizado");
        }

        [HttpGet]
        public async Task<ClienteDto> Get(Guid id)
        {
            return await _business.BuscarCliente(id);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _business.ExcluirCliente(id);
            return Ok("Objeto Deletado");
        }
    }
}
