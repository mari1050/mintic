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
    public class ListEmpresas : PageModel
    {
        
        private static IRepositorioEmpresa repoEmpresa = new RepositorioEmpresa(new Persistencia.AplicacionContext());

        //private readonly IRepositorioEmpresa repoEmpresa;
        public IEnumerable<Empresa> Empresas {get;set;}
        
        
        public void OnGet()
        {
            Empresas = repoEmpresa.getAll();
        }
    }
}
