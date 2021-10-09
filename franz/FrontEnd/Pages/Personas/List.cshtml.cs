using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Persistencia;
using Dominio;

namespace FrontEnd.Pages
{
    
    public class ListPersonas : PageModel
    {
        
        private static IRepositorioPersona repoPersona = new RepositorioPersona(new Persistencia.AplicacionContext());

        //private readonly ILogger<PersonaModel> _logger;
        //private readonly IRepositorioPersona repoPersona;
        public IEnumerable<Persona> Personas {get;set;}
        //public PersonaModel(ILogger<PersonaModel> logger)
        

        public void OnGet()
        {
            Personas = repoPersona.getAll();
        }

    }
}
