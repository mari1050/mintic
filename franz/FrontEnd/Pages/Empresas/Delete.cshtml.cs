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
    
    public class DeleteEmpresas : PageModel
    {
        private static IRepositorioEmpresa irepoclient= new RepositorioEmpresa(new Persistencia.AplicacionContext());
        [BindProperty]
        public Empresa Empresa_eliminar { get; set; }
        public void OnGet(int id)
        {
            Empresa_eliminar= irepoclient.GetEmpresa(id);
        }
        public void OnPost()
        {
           irepoclient.DeleteEmpresa(Empresa_eliminar.ID);
        }
    }
}
