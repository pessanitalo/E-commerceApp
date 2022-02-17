using Ecommerce.Bussines.Interfaces;
using Ecommerce.Bussines.Models;
using Ecommerce.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Data.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly DataContext _dataContext;

        public PedidoRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Pedido> CreatePedido(Pedido pedido)
        {
            _dataContext.Add(pedido);
            await _dataContext.SaveChangesAsync();
            return pedido;
        }

        public Pedido GetPedidoId(int id)
        {
            return _dataContext.Pedidos.AsNoTracking()
                .Include(c => c.Cliente)
                .Include(c => c.ItensPedidos)
                .FirstOrDefault(c => c.Id == id);
        }

        public Pedido[] GetPedidos()
        {
            IQueryable<Pedido> query = _dataContext.Pedidos;

            query = query.AsNoTracking().OrderBy(c => c.Id);
            return query.ToArray();
        }
    }
}
