using System.ComponentModel.DataAnnotations;

namespace BackendPruebaUSI.Models
{
    public class EntidadFederativa
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(32)]
        public string Nombre { get; set; }
    }
}
