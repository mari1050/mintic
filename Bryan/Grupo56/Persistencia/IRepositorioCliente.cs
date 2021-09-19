using Dominio;
using System.Colections.Generic;
namespace Persistencia
{
    public interface IRepositorioCliente
    {
        IEnumerable<Cliente> getAllCliente();
        Cliente AddCliente(Cliente cliente);
        Cliente UpdateCliente(Cliente cliente);
        void DeleteCliente(int idCliente);
        Cliente GetCliente(int idCliente);            
    }
}