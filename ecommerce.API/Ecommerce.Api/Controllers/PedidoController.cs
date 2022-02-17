using Ecommerce.Bussines.Interfaces;
using Ecommerce.Bussines.Models;
using Ecommerce.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Ecommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoRepository _pedidoRepository;
        public PedidoController(IPedidoRepository pedidorepository)
        {
            _pedidoRepository = pedidorepository;
        }

        [HttpGet]
        public IActionResult get()
        {
            var result = _pedidoRepository.GetPedidos();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult getById(int id)
        {
            var result = _pedidoRepository.GetPedidoId(id);
            if (result == null) return BadRequest("Pedido não encontrado");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Create(Pedido pedido)
        {
            if (pedido == null) return BadRequest("Erro ao salvar um produto");

            var result = await _pedidoRepository.CreatePedido(pedido);

            return Ok(result);
        }
    }
}
