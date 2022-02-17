using Ecommerce.Bussines.Interfaces;
using Ecommerce.Bussines.Models;
using Ecommerce.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Ecommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        //private readonly IRepository _repository;
        private readonly IProdutoRepository _produtoRepository;
        //IRepository repository,
        public ProdutoController( IProdutoRepository produtoRepository)
        {
            //_repository = repository;
            _produtoRepository = produtoRepository;
        }

        //ok
        [HttpGet]
        public IActionResult get()
        {
            var result = _produtoRepository.GetProdutos();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult getById(int id)
        {
            var result = _produtoRepository.GetProdutoId(id);
            if (result == null) return BadRequest("Produto não encontrado");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Create(Produto produto)
        {
            if (produto == null) return BadRequest("Erro ao salvar um produto");

            var result = await _produtoRepository.ProdutoCreate(produto);

            return Ok(result);
        }

        //public void updateProducts(int id, AtualizaEstoque valor)
        //{
        //    var result = _produtoRepository.GetProdutoId(id);
        //    result.TotalEstoque = result.TotalEstoque + valor.TotalEstoque;
        //}

        ////somente a pessoa autorizada podera adicionar itens ao estoque
        //[HttpPut("{id}")]
        //public ActionResult updateProduct(int id, AtualizaEstoque valor)
        //{
        //    var result = _repository.GetProdutoId(id);
        //    //result.TotalEstoque = result.TotalEstoque += valor;
        //    updateProducts(id, valor);

        //    _repository.Update(result);
        //    _repository.SaveChanges();
        //    return Ok(result);
        //}


    }
}
