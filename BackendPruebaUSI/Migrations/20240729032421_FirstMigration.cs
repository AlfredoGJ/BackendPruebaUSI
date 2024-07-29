using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendPruebaUSI.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nombres = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false),
                    ApellidoPaterno = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    ApellidoMaterno = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Edad = table.Column<int>(type: "integer", nullable: false),
                    Genero = table.Column<bool>(type: "boolean", nullable: false),
                    PuestoDeTrabajoId = table.Column<Guid>(type: "uuid", nullable: false),
                    DireccionId = table.Column<Guid>(type: "uuid", nullable: false),
                    GradoDeEstudiosId = table.Column<Guid>(type: "uuid", nullable: false),
                    TipoDeEmpleadoId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntidadesFederativas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nombre = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntidadesFederativas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GradosDeEstudios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nombre = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradosDeEstudios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PuestosDeTrabajo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nombre = table.Column<string>(type: "character varying(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuestosDeTrabajo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposDeEmpleado",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nombre = table.Column<string>(type: "character varying(16)", maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDeEmpleado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Telefonos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Numero = table.Column<string>(type: "character varying(12)", maxLength: 12, nullable: false),
                    Extension = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false),
                    Tipo = table.Column<string>(type: "character varying(16)", maxLength: 16, nullable: false),
                    EmpleadoId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefonos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telefonos_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Direcciones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Calle = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Numero = table.Column<int>(type: "integer", nullable: false),
                    CodigoPostal = table.Column<int>(type: "integer", nullable: false),
                    EntidadFederativaId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direcciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Direcciones_EntidadesFederativas_EntidadFederativaId",
                        column: x => x.EntidadFederativaId,
                        principalTable: "EntidadesFederativas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Direcciones_EntidadFederativaId",
                table: "Direcciones",
                column: "EntidadFederativaId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonos_EmpleadoId",
                table: "Telefonos",
                column: "EmpleadoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Direcciones");

            migrationBuilder.DropTable(
                name: "GradosDeEstudios");

            migrationBuilder.DropTable(
                name: "PuestosDeTrabajo");

            migrationBuilder.DropTable(
                name: "Telefonos");

            migrationBuilder.DropTable(
                name: "TiposDeEmpleado");

            migrationBuilder.DropTable(
                name: "EntidadesFederativas");

            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
