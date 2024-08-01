using BackendPruebaUSI.Repositories;
using BackendPruebaUSI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendPruebaUSI.Controllers
{
    [Route("api/puestosDeTrabajo")]
    [ApiController]
    public class PuestosDeTrabajoController : ControllerBase
    {
        private IPuestosDeTrabajoRepository _repository;

        public PuestosDeTrabajoController(IPuestosDeTrabajoRepository repository)
        {
            _repository = repository;
        }


        // GET: api/puestosDeTrabajo
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetAll());
        }

        // GET api/puestosDeTrabajo/5
        [HttpGet("{id:Guid}")]
        public IActionResult GetById(Guid id)
        {
            var p = _repository.GetById(id);
            if (p == null)
                return NotFound();
            return Ok(p);
        }

        
    }
}
