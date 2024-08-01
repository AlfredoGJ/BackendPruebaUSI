using BackendPruebaUSI.Repositories;
using BackendPruebaUSI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendPruebaUSI.Controllers
{
    [Route("api/entidadesFederativas")]
    [ApiController]
    public class EntidadesFederativasController : ControllerBase
    {
        private IEntidadesFederativasRepository _repository;

        public EntidadesFederativasController(IEntidadesFederativasRepository repository)
        {
            _repository = repository;
        }


        // GET: api/entidadesFederativas
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetAll());
        }

        // GET api/entidadesFederativas/5
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
