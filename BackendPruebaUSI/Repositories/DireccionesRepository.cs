using BackendPruebaUSI.Data;
using BackendPruebaUSI.Models;
using BackendPruebaUSI.Repositories.Interfaces;

namespace BackendPruebaUSI.Repositories
{
    public class DireccionesRepository : IDireccionesRepository
    {
        private readonly ApplicationDbContext _db;

        public DireccionesRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public void Create(Direccion direccion)
        {
            _db.Direcciones.Add(direccion);
            _db.SaveChanges();
        }

        public ICollection<Direccion> GetAll()
        {
            return _db.Direcciones.ToList();
        }

        public Direccion? GetById(Guid id)
        {
            return _db.Direcciones.FirstOrDefault(direccion => direccion.Id == id, null);
        }
    }
}
