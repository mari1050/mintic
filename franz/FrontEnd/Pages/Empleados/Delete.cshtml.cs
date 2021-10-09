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
    
    public class DeleteEmpleados : PageModel
    {
        private static IRepositorioEmpleado irepoempl= new RepositorioEmpleado(new Persistencia.AplicacionContext());
        [BindProperty]
        public Empleado EmpleadoEliminar { get; set; }
        public void OnGet(int id)
        {
            EmpleadoEliminar= irepoempl.GetEmpleado(id);
        }
        public void OnPost()
        {
           irepoempl.DeleteEmpleado(EmpleadoEliminar.ID);
        }
    }
}
