using System.ComponentModel.DataAnnotations;

namespace BackendPruebaUSI.Models.DTOs
{
    public class DireccionDto
    {
        public Guid Id { get; set; }
        [MaxLength(50)]
        public string Calle { get; set; }
        [Range(1, 30000)]
        public int Numero { get; set; }
        public int CodigoPostal { get; set; }
        public Guid EntidadFederativaId { get; set; }
    }
}
