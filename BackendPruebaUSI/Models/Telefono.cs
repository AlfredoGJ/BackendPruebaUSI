using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendPruebaUSI.Models
{
    public class Telefono
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(12)]
        public string Numero {  get; set; }
        [MaxLength(5)]
        public string Extension { get; set; }
        [MaxLength(16)]
        public string Tipo { get; set; }

        [ForeignKey("Empleado")]
        public Guid EmpleadoId { get; set; }
        //public virtual Empleado? Empleado { get; set; }
      

        public Telefono()
        {

        }
        public Telefono(string numero, string extension, string tipo, Guid empleadoId)
        {
            Numero = numero;
            Extension = extension;
            Tipo = tipo;
            EmpleadoId = empleadoId;
        }
    }
}
