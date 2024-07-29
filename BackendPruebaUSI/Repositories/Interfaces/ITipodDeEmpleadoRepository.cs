using BackendPruebaUSI.Models;
namespace BackendPruebaUSI.Repositories.Interfaces

{
    public interface ITipodDeEmpleadoRepository
    {
        ICollection<TipoDeEmpleado> GetAll();
        TipoDeEmpleado? GetById(Guid id);
    }
}
