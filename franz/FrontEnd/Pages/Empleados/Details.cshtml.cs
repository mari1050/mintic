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
    
    public class DetailsEmpleados : PageModel
    {
    
    private static IRepositorioEmpleado _repo = new RepositorioEmpleado(new Persistencia.AplicacionContext());
    
    //public IEnumerable<Empleado> Empleado {get;set;}
    public Empleado Empleado_get {get; set;}
    
        
    public void OnGet(int id)
        {
            Empleado_get = _repo.GetEmpleado(id);
        }
    }
}
