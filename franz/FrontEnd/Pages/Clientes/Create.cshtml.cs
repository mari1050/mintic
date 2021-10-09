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
    public class CreateClientes : PageModel
    {
        public IRepositorioCliente repoCliente = new RepositorioCliente(new Persistencia.AplicacionContext());

        [BindProperty]
        public Cliente ClienteNuevo { get; set; }
        public void OnGet()
        {

        }
        public void OnPost()
        {
            repoCliente.AddCliente(ClienteNuevo);
        }
    }
}
