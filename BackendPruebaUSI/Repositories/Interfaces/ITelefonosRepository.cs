using BackendPruebaUSI.Models;
namespace BackendPruebaUSI.Repositories.Interfaces

{
    public interface ITelefonosRepository
    {
        ICollection<Telefono> GetAll();
        //ICollection<Telefono> GetByEmpleadoId(Guid empleadoId);
        bool Create(Telefono telefono);
    }
}
