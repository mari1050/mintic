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
   
    public class DeleteModel : PageModel
    {
        public Cliente Persona { get; set; }
        private static IRepositorioCliente repoCliente = new RepositorioCliente(new Persistencia.AplicacionContext());
        public void OnGet(int id)
        {
            Persona = repoCliente.GetCliente(id);

        }
        public void OnPost(int id)
        {
            repoCliente.DeleteCliente(id);
        }
    }
}
