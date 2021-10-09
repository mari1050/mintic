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
    public class ListEmpleados : PageModel
    {
        
        private static IRepositorioEmpleado repoEmpleado = new RepositorioEmpleado(new Persistencia.AplicacionContext());

        //private readonly IRepositorioEmpleado repoEmpleado;
        public IEnumerable<Empleado> Empleados {get;set;}
        
        
        public void OnGet()
        {
            Empleados = repoEmpleado.getAll();
        }
    }
}
