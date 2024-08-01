using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendPruebaUSI.Migrations
{
    /// <inheritdoc />
    public partial class ChangesInNavigationProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefonos_Empleados_EmpleadoId",
                table: "Telefonos");

            migrationBuilder.AlterColumn<Guid>(
                name: "EmpleadoId",
                table: "Telefonos",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_DireccionId",
                table: "Empleados",
                column: "DireccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_GradoDeEstudiosId",
                table: "Empleados",
                column: "GradoDeEstudiosId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_PuestoDeTrabajoId",
                table: "Empleados",
                column: "PuestoDeTrabajoId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_TipoDeEmpleadoId",
                table: "Empleados",
                column: "TipoDeEmpleadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Direcciones_DireccionId",
                table: "Empleados",
                column: "DireccionId",
                principalTable: "Direcciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_GradosDeEstudios_GradoDeEstudiosId",
                table: "Empleados",
                column: "GradoDeEstudiosId",
                principalTable: "GradosDeEstudios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_PuestosDeTrabajo_PuestoDeTrabajoId",
                table: "Empleados",
                column: "PuestoDeTrabajoId",
                principalTable: "PuestosDeTrabajo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_TiposDeEmpleado_TipoDeEmpleadoId",
                table: "Empleados",
                column: "TipoDeEmpleadoId",
                principalTable: "TiposDeEmpleado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefonos_Empleados_EmpleadoId",
                table: "Telefonos",
                column: "EmpleadoId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Direcciones_DireccionId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_GradosDeEstudios_GradoDeEstudiosId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_PuestosDeTrabajo_PuestoDeTrabajoId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_TiposDeEmpleado_TipoDeEmpleadoId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefonos_Empleados_EmpleadoId",
                table: "Telefonos");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_DireccionId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_GradoDeEstudiosId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_PuestoDeTrabajoId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_TipoDeEmpleadoId",
                table: "Empleados");

            migrationBuilder.AlterColumn<Guid>(
                name: "EmpleadoId",
                table: "Telefonos",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefonos_Empleados_EmpleadoId",
                table: "Telefonos",
                column: "EmpleadoId",
                principalTable: "Empleados",
                principalColumn: "Id");
        }
    }
}
