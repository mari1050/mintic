using System.Runtime.InteropServices;
using Persistencia;
using Dominio;
using System;
namespace Aplicacion
{
    class Program
    {   
        private static iRepositorioEmpleado repoEmpleado = new RepositorioEmpleado(new Persistencia.AplicacionContext());
        private static iRepositorioCliente repoCliente = new RepositorioCliente(new Persistencia.AplicacionContext());
        private static iRepositorioEmpresa repoEmpresa = new RepositorioEmpresa(new Persistencia.AplicacionContext());
        static void Main(string[] args)

        {
            Console.WriteLine("Hola mundo Cruel!");
            addCliente();
            addEmpleado();
        }

        public static void addCliente()
        {
            var cliente= new Cliente{
                Nombre = "freddy",
                Apellido = "castano",
                Direccion = "Cll 35 33-56",
                Cedula= 10537558,
            }; 
            repoCliente.AddCliente(cliente);
        }
        public static void addEmpleado()
        {
            var empleado=new Empleado
            {
                Nombre="susana",
                Apellido = "arango",
                Cedula=6666,
                Tipo_empleado="Administrativo",
                Cantidad_subordinados=60

            };
            repoEmpleado.AddEmpleado(empleado);
        }

        public static void addEmpresa()
        {
            var empresa = new Empresa
            {
                Nombre = "BasPro_2",
                Nit = 700,
                Ciudad= "Bogota" ,
                Telefono =8864009,
            };
            repoEmpresa.AddEmpresa(empresa);
        }

    }
}