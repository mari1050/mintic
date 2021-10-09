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
    public class EditEmpleados : PageModel
    {
        
        private static IRepositorioEmpleado irepoemp= new RepositorioEmpleado(new Persistencia.AplicacionContext());
        
        [BindProperty]
        public Empleado EmpleadoEditar { get; set; }
        public void OnGet(int id)
        {
            EmpleadoEditar= irepoemp.GetEmpleado(id);
        }
        public void OnPost()
        {
            EmpleadoEditar = irepoemp.UpdateEmpleado(EmpleadoEditar);
        }
    }
}
