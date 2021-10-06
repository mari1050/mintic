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
    public class Detalle_Empleado : PageModel
    {
        private static iRepositorioEmpleado irepoemp= new RepositorioEmpleado(new Persistencia.AplicacionContext());
        public IEnumerable<Empleado> Empleado {get;set;}
        
        public Empleado Empleado_get {get;set;}

        public void OnGet(int id)
        {
            Empleado_get= irepoemp.GetEmpleado(id);
        }
    }
}
