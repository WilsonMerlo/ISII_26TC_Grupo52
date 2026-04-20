using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudIA.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materias_Usuarios_UsuarioIdUsuario",
                table: "Materias");

            migrationBuilder.DropIndex(
                name: "IX_Materias_UsuarioIdUsuario",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "UsuarioIdUsuario",
                table: "Materias");

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "IdUsuario", "Contrasena", "Correo", "Nombre" },
                values: new object[] { 1, "1234", "wilson@test.com", "Wilson Merlo" });

            migrationBuilder.InsertData(
                table: "Materias",
                columns: new[] { "IdMateria", "Descripcion", "IdUsuario", "NombreMateria" },
                values: new object[,]
                {
                    { 1, "Proyecto StudIA", 1, "Ingeniería de Software II" },
                    { 2, "Preparación de finales", 1, "Cálculo" },
                    { 3, "Modelos probabilísticos", 1, "Estadística" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Materias_IdUsuario",
                table: "Materias",
                column: "IdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Materias_Usuarios_IdUsuario",
                table: "Materias",
                column: "IdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materias_Usuarios_IdUsuario",
                table: "Materias");

            migrationBuilder.DropIndex(
                name: "IX_Materias_IdUsuario",
                table: "Materias");

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "IdMateria",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "IdMateria",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "IdMateria",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioIdUsuario",
                table: "Materias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Materias_UsuarioIdUsuario",
                table: "Materias",
                column: "UsuarioIdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Materias_Usuarios_UsuarioIdUsuario",
                table: "Materias",
                column: "UsuarioIdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
