using BackendPruebaUSI.Data;
using BackendPruebaUSI.Models;
using BackendPruebaUSI.Repositories.Interfaces;

namespace BackendPruebaUSI.Repositories
{
    public class EmpleadosRepository : IEmpleadosRepository
    {
        private readonly ApplicationDbContext _db;
        public void Create(Empleado empleado)
        {
            _db.Empleados.Add(empleado);
            _db.SaveChanges();
        }

        public bool Delete(Guid idEmpleado)
        {
            var empleado = _db.Empleados.Find(idEmpleado);
            if (empleado == null)
                return false;
            
            empleado.Deleted = true;
            _db.SaveChanges();
            return true;
        }

        public ICollection<Empleado> GetAll()
        {
            return _db.Empleados.ToList();
        }
    }
}
