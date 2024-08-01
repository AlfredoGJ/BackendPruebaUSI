using BackendPruebaUSI.Data;
using BackendPruebaUSI.Models;
using BackendPruebaUSI.Repositories.Interfaces;

namespace BackendPruebaUSI.Repositories
{
    public class EntidadesFederativasRepository : IEntidadesFederativasRepository
    {
        private readonly ApplicationDbContext _db;

        public EntidadesFederativasRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public ICollection<EntidadFederativa> GetAll()
        {
            return _db.EntidadesFederativas.ToList();
        }

        public EntidadFederativa? GetById(Guid id)
        {
            return _db.EntidadesFederativas.Find(id);
        }
    }
}
