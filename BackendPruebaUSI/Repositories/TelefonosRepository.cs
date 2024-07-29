using BackendPruebaUSI.Data;
using BackendPruebaUSI.Models;
using BackendPruebaUSI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackendPruebaUSI.Repositories
{
    public class TelefonosRepository : ITelefonosRepository
    {
        private readonly ApplicationDbContext _db;

        public TelefonosRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public void Create(Telefono telefono)
        {
            _db.Telefonos.Add(telefono);
            _db.SaveChanges();
        }

        public ICollection<Telefono> GetAll()
        {
            return _db.Telefonos.ToList();
        }

        public ICollection<Telefono> GetByUser(Guid userId)
        {
            return _db.Telefonos.Include(telefono => telefono.Empleado).Where(telefono => telefono.Empleado.Id == userId).ToList();
        }
    }
}
