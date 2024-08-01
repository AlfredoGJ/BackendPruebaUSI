using BackendPruebaUSI.Data;
using BackendPruebaUSI.Models;
using BackendPruebaUSI.Repositories.Interfaces;

namespace BackendPruebaUSI.Repositories
{
    public class TipoEmpleadoRepository : ITipodDeEmpleadoRepository
    {
        private readonly ApplicationDbContext _db;
        public TipoEmpleadoRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public ICollection<TipoDeEmpleado> GetAll()
        {
            return _db.TiposDeEmpleado.ToList();
        }

        public TipoDeEmpleado? GetById(Guid id)
        {
            return _db.TiposDeEmpleado.Find(id);
        }
    }
}
