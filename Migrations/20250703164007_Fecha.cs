using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaApi.Migrations
{
    /// <inheritdoc />
    public partial class Fecha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Tareas",
                newName: "EstadoT");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Tareas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EstadoT",
                table: "Tareas",
                newName: "Estado");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Tareas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
