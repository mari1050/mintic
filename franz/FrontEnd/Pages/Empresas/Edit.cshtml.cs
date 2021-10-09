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
    public class EditEmpresas : PageModel
    {private static IRepositorioEmpresa irepoemp= new RepositorioEmpresa(new Persistencia.AplicacionContext());
        
        [BindProperty]
        public Empresa EmpresaEditar { get; set; }
        public void OnGet(int id)
        {
            EmpresaEditar= irepoemp.GetEmpresa(id);
        }
        public void OnPost()
        {
            EmpresaEditar = irepoemp.UpdateEmpresa(EmpresaEditar);
        }
    }
}
