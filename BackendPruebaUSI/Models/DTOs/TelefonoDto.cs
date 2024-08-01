using System.ComponentModel.DataAnnotations;

namespace BackendPruebaUSI.Models.DTOs
{
    public class TelefonoDto
    {
        public Guid Id { get; set; }
        [MaxLength(12)]
        public string Numero { get; set; }
        [MaxLength(5)]
        public string Extension { get; set; }
        [MaxLength(16)]
        public string Tipo { get; set; }
    }
}
