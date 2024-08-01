using BackendPruebaUSI.Data;
using BackendPruebaUSI.Models;
using BackendPruebaUSI.Models.DTOs;
using BackendPruebaUSI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackendPruebaUSI.Repositories
{
    public class EmpleadosRepository : IEmpleadosRepository
    {
        private readonly ApplicationDbContext _db;

        public EmpleadosRepository(ApplicationDbContext db)
        {
            _db= db;
        }
        public bool Create(EmpleadoDataDto empleado)
        {

            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    // Add Direccion
                    var entidadFederativa = _db.EntidadesFederativas.Find(empleado.Direccion.EntidadFederativaId);
                    var direccionGuid = Guid.NewGuid();
                    var direccion = new Direccion(direccionGuid, empleado.Direccion.Calle, empleado.Direccion.Numero, empleado.Direccion.CodigoPostal, entidadFederativa);
                    _db.Direcciones.Add(direccion);

                    // Add Empleado
                    var puestoDeTrabajo = _db.PuestosDeTrabajo.Find(empleado.PuestoDeTrabajoId);
                    var gradoDeEstudios = _db.GradosDeEstudios.Find(empleado.GradoDeEstudiosId);
                    var tipoDeEmpleado = _db.TiposDeEmpleado.Find(empleado.TipoDeEmpleadoId);
                    var empleadoEntity = new Empleado(empleado.Nombres, empleado.ApellidoPaterno, empleado.ApellidoMaterno, empleado.Edad, empleado.Genero, empleado.PuestoDeTrabajoId, direccionGuid, empleado.GradoDeEstudiosId, empleado.TipoDeEmpleadoId);
                    _db.Empleados.Add(empleadoEntity);
                    // Add Telefonos
                    foreach (var t in empleado.Telefonos)
                    {
                        var tel = new Telefono(t.Numero, t.Extension, t.Tipo, empleadoEntity.Id);
                        _db.Telefonos.Add(tel);
                    }

                    _db.SaveChanges();
                    dbContextTransaction.Commit();
                    return true;
                }
                catch(Exception ex)
                {
                    return false;
                }
            }
             
            
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
            return _db.Empleados
                .Where(empleado => empleado.Deleted==false)
                .Include(empleado => empleado.GradoDeEstudios)
                .Include(empleado => empleado.TipoDeEmpleado)
                .Include (empleado => empleado.PuestoDeTrabajo)
                .Include(empleado => empleado.Direccion).ThenInclude(direccion=> direccion.EntidadFederativa)
                .Include(empleado => empleado.Telefonos)
                .ToList();
        }
    }
}
