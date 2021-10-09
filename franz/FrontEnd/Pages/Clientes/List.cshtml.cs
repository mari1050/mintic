using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;
using Dominio;

namespace FrontEnd.Pages
{
    public class ListClientes : PageModel
    {
        
        private static IRepositorioCliente repoCliente = new RepositorioCliente(new Persistencia.AplicacionContext());
        
        //private readonly IRepositorioCliente repoCliente;
        public IEnumerable<Cliente> Clientes {get;set;}
        
        
        public void OnGet()
        {
            Clientes = repoCliente.getAll();
        }
    }
}
