using Persistencia;
using Dominio;
using System;
namespace Aplicacion
{
    class Program
    {   
        private static IRepositorioEmpleado repoEmpleado = new RepositorioEmpleado(new Persistencia.AplicacionContext());
        private static IRepositorioCliente repoCliente = new RepositorioCliente(new Persistencia.AplicacionContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo Cruel!");
            addCliente();
            addEmpleado();
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
        public static void addEmpleado()
        {
            var empleado=new Empleado
            {
                Nombre="Milton",
                Edad=32,
                Documento=555555,
                Tipo_documento=2,
                variable=2
            };
            repoEmpleado.AddEmpleado(empleado);
        }
    }
}
