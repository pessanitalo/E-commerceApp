using Ecommerce.Bussines.Models;
using System.Threading.Tasks;

namespace Ecommerce.Bussines.Interfaces
{
    public interface IProdutoRepository
    {
        Produto[] GetProdutos();
        Produto GetProdutoId(int id);
        Task<Produto> ProdutoCreate(Produto produto);
    }
}
