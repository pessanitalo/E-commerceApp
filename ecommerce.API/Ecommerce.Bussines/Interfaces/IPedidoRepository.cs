using Ecommerce.Bussines.Models;
using System.Threading.Tasks;

namespace Ecommerce.Bussines.Interfaces
{
    public interface IPedidoRepository
    {
        Pedido[] GetPedidos();
        Pedido GetPedidoId(int id);
        Task<Pedido> CreatePedido(Pedido pedido);
    }
}
