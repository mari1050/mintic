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
    public class Consultas_Empresa : PageModel
    {

        private static iRepositorioEmpresa irepoempresa= new RepositorioEmpresa(new Persistencia.AplicacionContext());
        public IEnumerable<Empresa> Empresa {get;set;}


        public void OnGet()
        {
            Empresa= irepoempresa.getAll();

        }
    }
}
