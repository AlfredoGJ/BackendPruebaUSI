using BackendPruebaUSI.Models.DTOs;
using BackendPruebaUSI.Repositories;
using BackendPruebaUSI.Repositories.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendPruebaUSI.Controllers
{
    [Route("api/empleados")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private IEmpleadosRepository _repository;

        public EmpleadosController(IEmpleadosRepository repository)
        {
            _repository = repository;
        }


        // GET: api/empleados
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetAll());
        }
        // POST: api/empleados
        [HttpPost]
        public IActionResult CreateEmpleado([FromBody] EmpleadoDataDto empleado)
        {
           var result =  _repository.Create(empleado);
            if(result)
                return Ok();
            return BadRequest(result);

        }

        [HttpDelete("{id:Guid}")]
        public IActionResult DeleteEmpleado(Guid id)
        {
            var result = _repository.Delete(id);
            if(result)
                return Ok();
            return BadRequest(result);
        }

        
    }
}
