using BackendPruebaUSI.Data;
using BackendPruebaUSI.Models;
using BackendPruebaUSI.Repositories.Interfaces;

namespace BackendPruebaUSI.Repositories
{
    public class GradoDeEstudiosRepository : IGradosDeEstudioRepository
    {
        private readonly ApplicationDbContext _db;

        public GradoDeEstudiosRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public ICollection<GradoDeEstudios> GetAll()
        {
            return _db.GradosDeEstudios.ToList();
        }

        public GradoDeEstudios? GetById(Guid id)
        {
            return _db.GradosDeEstudios.Find(id);
        }
    }
}
