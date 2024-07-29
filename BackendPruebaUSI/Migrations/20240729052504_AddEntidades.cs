using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendPruebaUSI.Migrations
{
    /// <inheritdoc />
    public partial class AddEntidades : Migration
    {

       

        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            string[] Entidades = { "Aguascalientes", "Baja California", "Baja California Sur", "Campeche", "Chiapas", "Chihuahua", "Ciudad De México", "Coahuila De Zaragoza", "Colima", "Durango", "Guanajuato","Guerrero", "Hidalgo", "Jalisco", "Estado De México", "Michoacán De Ocampo", "Morelos", "Nayarit", "Nuevo León","Oaxaca", "Puebla", "Querétaro", "Quinata Roo", "San Luis Potosí", "Sinaloa", "Sonora", "Tabasco", "Tamaulipas", "Tlaxcala", "Veracruz", "Yucatán", "Zacatecas" };
            string[] GradosDeEstudios = { "Ninguno", "Primaria", "Secundaria", "Preparatoria", "Técnico", "Licenciatura", "Técnico Superior Universitaio", "Maestría", "Doctorado", "Especialidad", "Postdoctorado" };
            string[] TiposDeEmpleado = { "Administrativo", "Operativo" };
            string[] PuestosDeTrabajo = { "Becario", "Director", "Subdirector", "Secretaria(O)", "Tesorero", "Recepcionista", "Programador", "Tecnico en Mantenimiento", "Empleado De Limpieza", "Administrador", "Empleado De Seguridad" };

            foreach (string entidad in Entidades)
            {
                migrationBuilder.InsertData(table: "EntidadesFederativas", columns: new[] { "Id", "Nombre" }, values: new object[] { Guid.NewGuid().ToString(), entidad });
            }

            foreach (string estudios in GradosDeEstudios)
            {
                migrationBuilder.InsertData(table: "GradosDeEstudios", columns: new[] { "Id", "Nombre" }, values: new object[] { Guid.NewGuid().ToString(), estudios });
            }

            foreach (string empleado in TiposDeEmpleado)
            {
                migrationBuilder.InsertData(table: "TiposDeEmpleado", columns: new[] { "Id", "Nombre" }, values: new object[] { Guid.NewGuid().ToString(), empleado });
            }

            foreach (string puesto in PuestosDeTrabajo)
            {
                migrationBuilder.InsertData(table: "PuestosDeTrabajo", columns: new[] { "Id", "Nombre" }, values: new object[] { Guid.NewGuid().ToString(), puesto });
            }


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
