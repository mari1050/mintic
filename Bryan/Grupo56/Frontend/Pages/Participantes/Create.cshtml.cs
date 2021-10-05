using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;
using Microsoft.AspNetCore.Http;

namespace MyApp.Namespace
{
    public class CreateModel : PageModel
    {
        public Cliente Persona { get; set; }

        private static IRepositorioCliente repoCliente = new RepositorioCliente(new Persistencia.AplicacionContext());
        [BindProperty]
        public SubirArchivoModel SubirArchivo { get; set; }
        public void OnGet()
        {
        }
        public void OnPost(Cliente persona)
        {
            repoCliente.AddCliente(persona);

        }


    }
    public class SubirArchivoModel
    {
        public string Descripcion { get; set; }
        public IFormFile Archivo { get; set; }
    }
}
