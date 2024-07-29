using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendPruebaUSI.Models
{
    public class Direccion
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(50)]
        public string Calle { get; set; }
        [Range(1, 30000)]
        public int Numero { get; set; }
        public int CodigoPostal {  get; set; }
        public EntidadFederativa EntidadFederativa { get; set; }

    }
}
