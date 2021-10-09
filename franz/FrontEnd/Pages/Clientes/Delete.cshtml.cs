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
    
    public class DeleteClientes : PageModel
    {
        private static IRepositorioCliente irepoclient= new RepositorioCliente(new Persistencia.AplicacionContext());
        [BindProperty]
        public Cliente ClienteEliminar { get; set; }
        public void OnGet(int id)
        {
            ClienteEliminar= irepoclient.GetCliente(id);
        }
        public void OnPost()
        {
           irepoclient.DeleteCliente(ClienteEliminar.ID);
        }
    }
}
