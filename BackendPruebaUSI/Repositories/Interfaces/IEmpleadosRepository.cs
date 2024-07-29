using BackendPruebaUSI.Models;
namespace BackendPruebaUSI.Repositories.Interfaces

{
    public interface IEmpleadosRepository
    {
        ICollection<Empleado> GetAll();
        void Create(Empleado empleado);
        bool Delete(Guid empleadoId);


    }
}
