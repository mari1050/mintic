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
    
    public class DetailsEmpresas : PageModel
    {
    
    private static IRepositorioEmpresa _repo = new RepositorioEmpresa(new Persistencia.AplicacionContext());
    
    public Empresa Empresa_get {get; set;}
    
        
    public void OnGet(int id)
        {
            Empresa_get = _repo.GetEmpresa(id);
        }
    }
}
