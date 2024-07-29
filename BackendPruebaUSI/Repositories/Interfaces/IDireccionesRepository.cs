using BackendPruebaUSI.Models;
namespace BackendPruebaUSI.Repositories.Interfaces
{
    public interface IDireccionesRepository
    {
        ICollection<Direccion> GetAll();
        Direccion? GetById(Guid userId);
        void Create(Direccion direccion);
    }
}
