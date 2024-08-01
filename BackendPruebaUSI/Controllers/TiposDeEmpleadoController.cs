using BackendPruebaUSI.Repositories;
using BackendPruebaUSI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendPruebaUSI.Controllers
{
    [Route("api/tiposDeEmpleado")]
    [ApiController]
    public class TiposDeEmpleadoController : ControllerBase
    {
        private ITipodDeEmpleadoRepository _repository;

        public TiposDeEmpleadoController(ITipodDeEmpleadoRepository repository)
        {
            _repository = repository;
        }


        // GET: api/tiposDeEmpleado
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetAll());
        }

        // GET api/tiposDeEmpleado/5
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
