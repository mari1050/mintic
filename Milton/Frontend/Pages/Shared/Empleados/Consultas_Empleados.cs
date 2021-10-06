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
    public class Consulta_Empleados : PageModel
    {
        private static iRepositorioEmpleado irepoemp= new RepositorioEmpleado(new Persistencia.AplicacionContext());
        public IEnumerable<Empleado> Empleados {get;set;}

        public void OnGet()
        {
            Empleados= irepoemp.getAll();
        }
    }
}
