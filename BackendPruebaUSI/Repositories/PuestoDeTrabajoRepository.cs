using BackendPruebaUSI.Data;
using BackendPruebaUSI.Models;
using BackendPruebaUSI.Repositories.Interfaces;

namespace BackendPruebaUSI.Repositories
{
    public class PuestoDeTrabajoRepository : IPuestosDeTrabajoRepository
    {
        private readonly ApplicationDbContext _db;

        public PuestoDeTrabajoRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public ICollection<PuestoDeTrabajo> GetAll()
        {
            return _db.PuestosDeTrabajo.ToList();
        }

        public PuestoDeTrabajo? GetById(Guid id)
        {
            return _db.PuestosDeTrabajo.FirstOrDefault(puesto =>  puesto.Id == id, null);
        }
    }
}
