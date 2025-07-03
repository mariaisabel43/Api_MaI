using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaApi.Migrations
{
    /// <inheritdoc />
    public partial class TareasP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Tareas",
                newName: "Titulo");

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Tareas",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Tareas");

            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "Tareas",
                newName: "Name");
        }
    }
}
