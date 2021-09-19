using Persistencia;
using Dominio;
using System;
namespace Aplicacion
{
    class Program
    {   
        private static IRepositorioCliente repoCliente = new RepositorioCliente(new Persistencia.AplicacionContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo Cruel!");
            addCliente();
        }

        public static void addCliente()
        {
            var cliente= new Cliente{
                Nombre = "Bryan",
                Edad = 29,
                Documento = 1053827059,
                Tipo_documento = 1
            }; 
            repoCliente.AddCliente(cliente);
        }
    }
}
