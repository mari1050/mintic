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
    //

    public class Nuevo_Empleado : PageModel
    {

        public iRepositorioEmpleado repoEmpleado = new RepositorioEmpleado(new Persistencia.AplicacionContext());

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