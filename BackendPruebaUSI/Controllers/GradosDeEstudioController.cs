using BackendPruebaUSI.Repositories;
using BackendPruebaUSI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendPruebaUSI.Controllers
{
    [Route("api/gradosDeEstudio")]
    [ApiController]
    public class GradosDeEstudioController : ControllerBase
    {
        private IGradosDeEstudioRepository _repository;

        public GradosDeEstudioController(IGradosDeEstudioRepository repository)
        {
            _repository = repository;
        }


        // GET: api/gradosDeEstudio
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetAll());
        }

        // GET api/gradosDeEstudio/5
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
