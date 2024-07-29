using System.ComponentModel.DataAnnotations;

namespace BackendPruebaUSI.Models
{
    public class TipoDeEmpleado
    {
        
            [Key]
            public Guid Id { get; set; }
            [Required]
            [MaxLength(16)]
            public string Nombre { get; set; }

        
    }
}
