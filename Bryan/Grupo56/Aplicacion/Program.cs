using System;
using Persistencia;
using Dominio;
namespace Aplicacion
{
    class Program
    {   
        private static IRepositrioCliente repoCliente= new RepositorioCliente(new Persistencia.AplicacionContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo Cruel!");
        }

        public static void addCliente(){
            var cliente= new Cliente{
                Nombre="Bryan",
                Edad=29,
                Documento=1053827059,
                Tipo_Documento=1
            };
            repoCliente.AddCliente(cliente);

        }
    }
}
