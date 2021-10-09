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
    public class EditClientes : PageModel
    {private static IRepositorioCliente irepoemp= new RepositorioCliente(new Persistencia.AplicacionContext());
        
        [BindProperty]
        public Cliente ClienteEditar { get; set; }
        public void OnGet(int id)
        {
            ClienteEditar= irepoemp.GetCliente(id);
        }
        public void OnPost()
        {
            ClienteEditar = irepoemp.UpdateCliente(ClienteEditar);
        }
    }
}
