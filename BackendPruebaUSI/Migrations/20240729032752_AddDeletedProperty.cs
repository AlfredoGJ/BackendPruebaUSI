using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendPruebaUSI.Migrations
{
    /// <inheritdoc />
    public partial class AddDeletedProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Empleados",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Empleados");
        }
    }
}
