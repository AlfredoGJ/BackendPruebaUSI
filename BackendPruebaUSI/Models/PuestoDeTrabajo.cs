using System.ComponentModel.DataAnnotations;

namespace BackendPruebaUSI.Models
{
    public class PuestoDeTrabajo
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(120)]
        public string Nombre { get; set; }

    }
}
