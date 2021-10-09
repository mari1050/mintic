using Dominio;
using System.Collections.Generic;
namespace Persistencia
{
    public interface IRepositorioCliente
    {
         IEnumerable<Cliente> getAll();
         
         Cliente AddCliente(Cliente cliente);

         Cliente UpdateCliente(Cliente cliente);

         void DeleteCliente(int idCliente);

         Cliente GetCliente(int idCliente);
    }
}