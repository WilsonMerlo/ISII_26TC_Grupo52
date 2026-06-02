using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudIA.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateApunteYReglasCascada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_modificacion",
                table: "Apuntes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fecha_modificacion",
                table: "Apuntes");
        }
    }
}
