using Ecommerce.Bussines.Interfaces;
using Ecommerce.Bussines.Models;
using Ecommerce.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Data.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly DataContext _dataContext;

        public ProdutoRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public Produto GetProdutoId(int id)
        {
            return _dataContext.Produtos.Find(id);
        }

        public Produto[] GetProdutos()
        {
            IQueryable<Produto> query = _dataContext.Produtos;

            query = query.AsNoTracking().OrderBy(c => c.Id);
            return query.ToArray();
        }

        public async Task<Produto> ProdutoCreate(Produto produto)
        {
            _dataContext.Add(produto);
            await _dataContext.SaveChangesAsync();
            return produto;
        }
    }
}
