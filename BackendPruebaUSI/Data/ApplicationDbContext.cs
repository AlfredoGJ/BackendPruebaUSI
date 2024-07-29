using BackendPruebaUSI.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendPruebaUSI.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<PuestoDeTrabajo> PuestosDeTrabajo { get; set; }
        public DbSet<TipoDeEmpleado> TiposDeEmpleado { get; set; }
        public DbSet<GradoDeEstudios> GradosDeEstudios { get; set; }
        public DbSet<EntidadFederativa> EntidadesFederativas { get; set; }
        public DbSet<Telefono> Telefonos { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
    }
}
