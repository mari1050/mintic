using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Dominio;
using Persistencia;


namespace Frontend.Pages
{
public class PrivacyModel : PageModel
    {
       //private string[] saludos = { "Buenos dias", "Buenas tardes", "Buenas noches", "Hasta mañana" };
       // public List<string> ListaSaludos { get; set; }
       private static IRepositorioCliente repoCliente = new RepositorioCliente(new Persistencia.AplicacionContext());
       public IEnumerable<Cliente> Cliente {get;set;}


       
        public void OnGet()
        {
           // ListaSaludos = new List<string>();
           // ListaSaludos.AddRange(saludos);
          Cliente=repoCliente.GetAllCliente();

        }
    }
}
