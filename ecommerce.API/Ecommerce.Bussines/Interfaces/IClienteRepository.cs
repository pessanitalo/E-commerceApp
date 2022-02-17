using Ecommerce.Bussines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Bussines.Interfaces
{
    public interface IClienteRepository
    {
        Cliente[] GetClientes();
        Cliente GetClienteById(int id);
        Task<Cliente> CreateCliente(Cliente cliente);
    }
}
