using BackendPruebaUSI.Models;
namespace BackendPruebaUSI.Repositories.Interfaces

{
    public interface ITelefonosRepository
    {
        ICollection<Telefono> GetAll();
        ICollection<Telefono> GetByUser(Guid userId);
        void Create(Telefono telefono);
    }
}
