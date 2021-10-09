using System.ComponentModel;
using System;
using Dominio;
using Persistencia;
namespace Aplicacion
{
    class Program
    {
        
        private static IRepositorioCliente repoCliente = new RepositorioCliente(new Persistencia.AplicacionContext());
        private static IRepositorioPersona repoPersona = new RepositorioPersona(new Persistencia.AplicacionContext());
        private static IRepositorioEmpleado repoEmpleado = new RepositorioEmpleado(new Persistencia.AplicacionContext());
        private static IRepositorioEmpresa repoEmpresa= new RepositorioEmpresa(new Persistencia.AplicacionContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecución de CRUD para Clientes !");
            addCliente();
            updateCliente();
            //deleteCliente();
            getCliente(1);

            Console.WriteLine("Ejecución de CRUD para Personas !");
            addPersona();
            updatePersona();
            //deletePersona();
            getPersona(1);

            Console.WriteLine("Ejecución de CRUD para Empleados !");
            addEmpleado();
            updateEmpleado();
            //deleteEmpleado();
            getEmpleado(1);

            Console.WriteLine("Ejecución de CRUD para Empresa !");
            addEmpresa();
            //updateEmpresa();
            //deleteEmpresa();
            getEmpresa(1);
        }

        public static void addCliente(){
            var cliente = new Cliente{
                Nombre = "Franz",
                Apellido = "Fernandez",
                Cedula = 123456,
                Direccion = "Calle 13Sur #8-50"
            };
            repoCliente.AddCliente(cliente);
        }

        public static void getCliente(int idCliente){
            var Cliente =  repoCliente.GetCliente(idCliente);
            if(Cliente==null)
            return ;
            Console.WriteLine(Cliente.Nombre + " " +Cliente.Apellido
            + " "+ Cliente.Cedula + " "+ Cliente.Direccion);
        }

        public static void deleteCliente(){
            repoCliente.DeleteCliente(1);
        }

        public static void updateCliente(){
            var cliente = new Cliente{
                ID = 1,
                Nombre = "Franz David Konstantino",
                Apellido = "Fernandez Acurero",
                Cedula = 1193646167,
                Direccion = "Calle 13Sur #8-50 aptto 602"
            };
            repoCliente.UpdateCliente(cliente);
        }
        public static void addPersona(){
            var persona = new Persona{
                Nombre = "Franz",
                Apellido = "Fernandez",
                Cedula = 123456,
                
            };
            repoPersona.AddPersona(persona);
        }

        public static void deletePersona(){
            repoPersona.DeletePersona(1);
        }

        public static void getPersona(int idPersona){
            var Persona =  repoPersona.GetPersona(idPersona);
            if(Persona==null)
            return ;
            Console.WriteLine(Persona.Nombre + " " +Persona.Apellido
            + " "+ Persona.Cedula);
        }
        public static void updatePersona(){
            var persona = new Persona{
                ID = 1,
                Nombre = "Franz David Konstantino",
                Apellido = "Fernandez Acurero",
                Cedula = 1193646167,
            };
            repoPersona.UpdatePersona(persona);
        }
        public static void addEmpleado(){
            var empleado = new Empleado{
                Nombre = "Franz",
                Apellido = "Fernandez",
                Cedula = 123456,
                Tipo_empleado = "Programador Junior",
                Cantidad_subordinados = 1
                
            };
            repoEmpleado.AddEmpleado(empleado);
        }

        public static void deleteEmpleado(){
            repoEmpleado.DeleteEmpleado(1);
        }

        public static void getEmpleado(int idEmpleado){
            var Empleado =  repoEmpleado.GetEmpleado(idEmpleado);
            if(Empleado==null)
            return ;
            Console.WriteLine(Empleado.Nombre + " " +Empleado.Apellido
            + " "+ Empleado.Cedula + " "+ Empleado.Tipo_empleado);
        }

        public static void updateEmpleado(){
            var empleado = new Empleado{
                ID = 1,
                Nombre = "Franz David Konstantino",
                Apellido = "Fernandez Acurero",
                Cedula = 1193646167,
                Tipo_empleado = "Programador Senior",
                Cantidad_subordinados = 10
            };
            repoEmpleado.UpdateEmpleado(empleado);
        }

        public static void addEmpresa(){
            var empresa = new Empresa{
                Nombre = "EQ1",
                Nit = 11111111,
                Ciudad = "Bogotá",
                Telefono = 1852469
            };
            repoEmpresa.AddEmpresa(empresa);
        }

        public static void deleteEmpresa(){
            repoEmpresa.DeleteEmpresa(1);
        }

        

        public static void updateEmpresa(){
            var empresa = new Empresa{
                ID = 1,
                Nombre = "PROSET",
                Nit = 9999999,
                Ciudad = "Maracaibo",
                Telefono = 31336946
            };
            repoEmpresa.UpdateEmpresa(empresa);
        }

        public static void getEmpresa(int idEmpresa){
            var Empresa =  repoEmpresa.GetEmpresa(idEmpresa);
            if(Empresa==null)
            return ;
            Console.WriteLine(Empresa.Nombre + " " +Empresa.Nit
            + " "+ Empresa.Ciudad + " "+ Empresa.Telefono);
        }
    }
}
