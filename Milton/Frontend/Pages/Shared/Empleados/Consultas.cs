using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Dominio;
using Persistencia;

namespace Frontend.Pages
{
    public class PrivacyModel : PageModel
    {
        private static iRepositorioEmpleado irepoemp= new RepositorioEmpleado(new Persistencia.AplicacionContext());
        public IEnumerable<Empleado> Empleado {get;set;}
        private static iRepositorioCliente irepocliente= new RepositorioCliente(new Persistencia.AplicacionContext());
        public IEnumerable<Cliente> Clientes {get;set;}

        public void OnGet()
        {
            Empleado= irepoemp.getAll();
            Clientes= irepocliente.getAll();
        }
    }
}
