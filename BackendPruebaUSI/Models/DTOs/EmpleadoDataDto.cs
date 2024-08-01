using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BackendPruebaUSI.Models.DTOs
{
    public class EmpleadoDataDto
    {
        public Guid Id { get; set; }
        [MaxLength(60)]
        public string Nombres { get; set; }
        [MaxLength(30)]
        public string ApellidoPaterno { get; set; }
        [MaxLength(30)]
        public string ApellidoMaterno { get; set; }
        [Range(1, 99)]
        public int Edad { get; set; }
        public bool Deleted { get; set; }

        public bool Genero { get; set; }
        
        public Guid PuestoDeTrabajoId { get; set; }

        public Guid GradoDeEstudiosId { get; set; }
      
        public Guid TipoDeEmpleadoId { get; set; }
        public DireccionDto Direccion { get; set; }
        public ICollection<TelefonoDto> Telefonos { get; set; }
    }
}
