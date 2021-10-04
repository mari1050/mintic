using System.Collections.Generic;
using System.Linq;
using Dominio;
namespace Persistencia
{
    public class RepositorioCliente:IRepositorioCliente
    {
        private readonly AplicacionContext _appContext;
        public RepositorioCliente(AplicacionContext appContext)
        {
            _appContext=appContext;
        }

        public Cliente AddCliente(Cliente cliente)
        {
            var nuevo_cliente=_appContext.Add(cliente);
            _appContext.SaveChanges();
            return nuevo_cliente.Entity;
        }

        public void DeleteCliente(int idCliente)
        {
            var cliente_encontrado=_appContext.Clientes.FirstOrDefault(
                p=>p.Id==idCliente
            );
            if (cliente_encontrado==null)
            return ;
            _appContext.Remove(cliente_encontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Cliente> GetAllCliente()
        {
            return _appContext.Clientes;
        }
        public Cliente GetCliente(int idCliente)
        {
            return _appContext.Clientes.FirstOrDefault(
                p=> p.Id==idCliente
            );
        }
        /*public Cliente UpdateCliente(Cliente cliente)
        {
            var cliente_encontrado=_appContext.Clientes.FirstOrDefault(
                p=>p.Id==cliente.Id
            );
            if(cliente_encontrado!=null)
            {
                cliente_encontrado.Nombre_Cliente=cliente.Nombre_Cliente;
                cliente_encontrado.Telefono=cliente.Telefono;
                cliente_encontrado.Tipo_documento=cliente.Tipo_documento;
                cliente_encontrado.Documento=cliente.Documento;
            }
            return cliente_encontrado;
        }*/

    }
}