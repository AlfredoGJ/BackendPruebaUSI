using BackendPruebaUSI.Models;
namespace BackendPruebaUSI.Repositories.Interfaces

{
    public interface IGradosDeEstudioRepository
    {
        ICollection<GradoDeEstudios> GetAll();
        GradoDeEstudios? GetById(Guid id);
    }
}
