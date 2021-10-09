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
    public class CreateEmpresas : PageModel
    {
        public IRepositorioEmpresa repoEmpresa = new RepositorioEmpresa(new Persistencia.AplicacionContext());

        [BindProperty]
        public Empresa EmpresaNuevo { get; set; }
        public void OnGet()
        {

        }
        public void OnPost()
        {
            repoEmpresa.AddEmpresa(EmpresaNuevo);
        }
    }
}
