using BackendPruebaUSI.Models;
using BackendPruebaUSI.Models.DTOs;

namespace BackendPruebaUSI.Repositories.Interfaces

{
    public interface IEmpleadosRepository
    {
        ICollection<Empleado> GetAll();
        bool Create(EmpleadoDataDto empleado);
        bool Delete(Guid empleadoId);


    }
}
