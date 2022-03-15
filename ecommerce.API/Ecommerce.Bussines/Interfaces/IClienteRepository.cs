using Ecommerce.Bussines.Models;
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
