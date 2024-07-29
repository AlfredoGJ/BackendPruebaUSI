using System.ComponentModel.DataAnnotations;

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
        public Empleado? Empleado { get; set; }
      

    }
}
