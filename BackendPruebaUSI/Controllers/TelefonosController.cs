using BackendPruebaUSI.Models;
using BackendPruebaUSI.Repositories;
using BackendPruebaUSI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendPruebaUSI.Controllers
{
    [Route("api/telefonos")]
    [ApiController]
    public class TelefonosController : ControllerBase
    {
        private ITelefonosRepository _repository;

        public TelefonosController(ITelefonosRepository repository)
        {
            _repository = repository;
        }


        // GET: api/telefonos
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetAll());
        }

        // GET api/telefonos/5
        //[HttpGet("{id:Guid}")]
        //public IActionResult GetByUserId(Guid userId)
        //{
        //    var t = _repository.GetByEmpleadoId(userId);
        //    if (t == null)
        //        return NotFound();
        //    return Ok(t);
        //}

        //[HttpPost]
        //public IActionResult CreateTelefono([FromBody] Telefono telefono)
        //{
        //  var result =  _repository.Create(telefono);

        //    if (result)
        //        return Ok();
        //    else
        //        return BadRequest();
        //}

        
    }
}
