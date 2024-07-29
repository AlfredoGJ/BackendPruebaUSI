using System.ComponentModel.DataAnnotations;

namespace BackendPruebaUSI.Models
{
    public class GradoDeEstudios
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Nombre { get; set; }
    }
}
