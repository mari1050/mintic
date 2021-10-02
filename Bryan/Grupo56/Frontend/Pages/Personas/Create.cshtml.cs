using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;
namespace MyApp.Namespace
{
    public class CreateModel : PageModel
    {
        public Cliente Persona { get; set; }
        private static IRepositorioCliente repoCliente = new RepositorioCliente(new Persistencia.AplicacionContext());

        public void OnGet()
        {
        }
        public void OnPost(Cliente persona)
        {
            repoCliente.AddCliente(persona);

        }
    }
}


