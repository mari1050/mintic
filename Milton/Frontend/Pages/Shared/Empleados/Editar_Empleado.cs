using System.ComponentModel.DataAnnotations;
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
    public class Editar_Empleado : PageModel
    {
        private static iRepositorioEmpleado irepoemp= new RepositorioEmpleado(new Persistencia.AplicacionContext());
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
