using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioCliente: iRepositorioCliente
    {
       private readonly AplicacionContext _appContext;

       public RepositorioCliente(AplicacionContext appContext)
       {
           _appContext = appContext;
       }

        public Cliente AddCliente(Cliente cliente)
        {
            var nuevo_cliente = _appContext.Add(cliente);
            _appContext.SaveChanges();
            return nuevo_cliente.Entity;
        }

        public void DeleteCliente(int idCliente)
        {
            var encontrado_Cliente = _appContext.Clientes.FirstOrDefault(
                p => p.ID == idCliente
            );

            if(encontrado_Cliente == null)
            return;
            _appContext.Remove(encontrado_Cliente);
            _appContext.SaveChanges();

        }

        public IEnumerable<Cliente> getAll()
        {
            return _appContext.Clientes;
        }

        public Cliente GetCliente(int idCliente)
        {
            return _appContext.Clientes.FirstOrDefault(
                p => p.ID == idCliente 
            );
        }

        public Cliente UpdateCliente(Cliente cliente)
        {
            var encontrado_Cliente = _appContext.Clientes.FirstOrDefault(
                p => p.ID == cliente.ID
            );

            if(encontrado_Cliente != null)
            {
                encontrado_Cliente.Nombre = cliente.Nombre;
                encontrado_Cliente.Apellido = cliente.Apellido;
                encontrado_Cliente.Cedula = cliente.Cedula;
                encontrado_Cliente.Direccion = cliente.Direccion;
                
                _appContext.SaveChanges();
            }
            return encontrado_Cliente;
        }
    }
}