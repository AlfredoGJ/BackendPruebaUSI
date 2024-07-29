using BackendPruebaUSI.Models;
namespace BackendPruebaUSI.Repositories.Interfaces
{
    public interface IPuestosDeTrabajoRepository
    {
        ICollection<PuestoDeTrabajo> GetAll();
        PuestoDeTrabajo? GetById(Guid id);
    }
}
