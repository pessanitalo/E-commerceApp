using Ecommerce.Bussines.Interfaces;
using Ecommerce.Bussines.Models;
using Ecommerce.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Ecommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly IClienteRepository _Clienterepository;
        public ClienteController(IClienteRepository clienteRepository)
        {
            _Clienterepository = clienteRepository;
        }
        //ok
        [HttpGet]
        public IActionResult get()
        {
            var result = _Clienterepository.GetClientes();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult getById(int id)
        {
            var result = _Clienterepository.GetClienteById(id);
            if (result == null) return BadRequest("Cliente não encontrado");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Create(Cliente cliente)
        {
            if (cliente == null) return BadRequest("Erro ao salvar um produto");

            var result = await _Clienterepository.CreateCliente(cliente);

            return Ok(result);
        }

    }
}
