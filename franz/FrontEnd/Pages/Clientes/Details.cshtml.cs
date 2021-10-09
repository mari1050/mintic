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
    
    public class DetailsClientes : PageModel
    {
    
    private static IRepositorioCliente _repo = new RepositorioCliente(new Persistencia.AplicacionContext());
    
    public IEnumerable<Cliente> Cliente {get;set;}
    public Cliente Cliente_get {get; set;}
    
        
    public void OnGet(int id)
        {
            Cliente_get = _repo.GetCliente(id);
        }
    }
}
