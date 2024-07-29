using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendPruebaUSI.Models
{
    public class Empleado
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(60)]
        public string Nombres { get; set; }
        [MaxLength(30)]
        public string ApellidoPaterno { get; set; }
        [MaxLength(30)]
        public string ApellidoMaterno { get; set; }
        [Range(1,99)]
        public int Edad {  get; set; }
        public bool Deleted { get; set; }
        
        public bool Genero { get; set; }
        [ForeignKey("PuestoDeTrabajo")]
        public Guid PuestoDeTrabajoId { get; set; }
        [ForeignKey("Direccion")]
        public Guid DireccionId { get; set; }
        [ForeignKey("GradoDeEstudios")]
        public Guid GradoDeEstudiosId { get; set; }
        [ForeignKey("TipoDeEmpleado")]
        public Guid TipoDeEmpleadoId { get; set; }
        public ICollection<Telefono>? Telefonos { get; set; }
    }
}
