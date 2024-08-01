using BackendPruebaUSI.Repositories;
using BackendPruebaUSI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendPruebaUSI.Controllers
{
    [Route("api/direcciones")]
    [ApiController]
    public class DireccionesController : ControllerBase
    {
        private IDireccionesRepository _repository;

        public DireccionesController(IDireccionesRepository repository)
        {
            _repository = repository;
        }


        // GET: api/puestosDeTrabajo
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetAll());
        }

        // GET api/direcciones/empleado/5
        [HttpGet("empleado/{id:Guid}")]
        public IActionResult GetByEmpleadoId(Guid empleadoId)
        {
            var p = _repository.GetByEmpleadoId(empleadoId);
            if (p == null)
                return NotFound();
            return Ok(p);
        }

        
    }
}
