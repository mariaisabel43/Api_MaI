using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaApi.Migrations
{
    /// <inheritdoc />
    public partial class TareaP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Curso",
                table: "Tareas",
                newName: "Detalles");

            migrationBuilder.AlterColumn<string>(
                name: "Prioridad",
                table: "Tareas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaEntrega",
                table: "Tareas",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<bool>(
                name: "Estado",
                table: "Tareas",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Detalles",
                table: "Tareas",
                newName: "Curso");

            migrationBuilder.AlterColumn<string>(
                name: "Prioridad",
                table: "Tareas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "FechaEntrega",
                table: "Tareas",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Tareas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
