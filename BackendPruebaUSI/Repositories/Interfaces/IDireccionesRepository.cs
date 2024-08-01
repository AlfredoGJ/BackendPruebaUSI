using BackendPruebaUSI.Models;
namespace BackendPruebaUSI.Repositories.Interfaces
{
    public interface IDireccionesRepository
    {
        ICollection<Direccion> GetAll();
        Direccion? GetByEmpleadoId(Guid empleadoId);
        void Create(Direccion direccion);
    }
}
