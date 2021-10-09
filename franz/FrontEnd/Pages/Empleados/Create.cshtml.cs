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
    public class CreateEmpleados : PageModel
    {
        public IRepositorioEmpleado repoEmpleado = new RepositorioEmpleado(new Persistencia.AplicacionContext());

        [BindProperty]
        public Empleado EmpleadoNuevo { get; set; }
        public void OnGet()
        {

        }
        public void OnPost()
        {
            repoEmpleado.AddEmpleado(EmpleadoNuevo);
        }
    }
}
