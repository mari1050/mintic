namespace Dominio
{
    public class Empleado
    {
        public int ID {get;set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Cedula {get;set; }

        public string Tipo_empleado { get; set; }

        public int Cantidad_subordinados {get;set; }
    }
}