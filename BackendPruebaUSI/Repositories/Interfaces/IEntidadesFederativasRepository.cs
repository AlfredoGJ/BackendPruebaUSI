using BackendPruebaUSI.Models;
namespace BackendPruebaUSI.Repositories.Interfaces

{
    public interface IEntidadesFederativasRepository
    {
        ICollection<EntidadFederativa> GetAll();
        EntidadFederativa? GetById(Guid id);  
    }
}
