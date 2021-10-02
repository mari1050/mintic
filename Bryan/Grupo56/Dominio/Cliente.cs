using System.ComponentModel.DataAnnotations;
namespace Dominio
{
    public class Cliente
    {
        public int Id {get; set;}

        //[Required(ErrorMessage = "El Nombre es requerido")]
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Tipo_documento {get; set;}
        public int Documento {get; set;}
    }
}