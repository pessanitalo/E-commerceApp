using Ecommerce.Bussines.Interfaces;
using Ecommerce.Bussines.Models;
using Ecommerce.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DataContext _dataContext;

        public ClienteRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Cliente> CreateCliente(Cliente cliente)
        {
            _dataContext.Add(cliente);
            await _dataContext.SaveChangesAsync();
            return cliente;
        }

        public Cliente GetClienteById(int id)
        {
            return _dataContext.Clientes.Find(id);
        }

        public Cliente[] GetClientes()
        {
            IQueryable<Cliente> query = _dataContext.Clientes;

            query = query.AsNoTracking().OrderBy(c => c.Id);
            return query.ToArray();
        }
    }
}
