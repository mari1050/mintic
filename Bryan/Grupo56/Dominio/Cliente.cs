using System.ComponentModel.DataAnnotations;
namespace Dominio
{
    public class Cliente
    {
        public int Id {get; set;}
        public string Nombre_Cliente { get; set; }

        //[Required(ErrorMessage = "El Nombre es requerido")]
        public string Contacto_Autorizado { get; set; }
        public string Cargo { get; set; }
        public long Celular {get; set;}
        public long Telefono {get; set;}
        public string Correo_Electronico { get; set; }
        public string Correo_Electronico2 { get; set; }
        public string Ciudad { get; set; }
        public string Direccion_Oficina { get; set; }
    }
}