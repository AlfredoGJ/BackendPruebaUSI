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
        [ForeignKey("EntidadFederativa")]
        public Guid EntidadFederativaId {  get; set; } 
        public virtual EntidadFederativa EntidadFederativa { get; set; }


        public Direccion() { }
        public Direccion(Guid id, string calle, int numero, int codigoPostal, EntidadFederativa entidad) {
        
            this.Id = id;
            this.Calle = calle;
            this.Numero = numero;
            this.CodigoPostal = codigoPostal;
            this.EntidadFederativa = entidad;
        }

    }
}
