using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudIA.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProgresoSegundos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Progresos_Materias_id_materia",
                table: "Progresos");

            migrationBuilder.DropColumn(
                name: "avance_porcentual",
                table: "Progresos");

            migrationBuilder.AddColumn<int>(
                name: "segundos_acumulados",
                table: "Progresos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Progresos_Materias_id_materia",
                table: "Progresos",
                column: "id_materia",
                principalTable: "Materias",
                principalColumn: "id_materia",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Progresos_Materias_id_materia",
                table: "Progresos");

            migrationBuilder.DropColumn(
                name: "segundos_acumulados",
                table: "Progresos");

            migrationBuilder.AddColumn<float>(
                name: "avance_porcentual",
                table: "Progresos",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddForeignKey(
                name: "FK_Progresos_Materias_id_materia",
                table: "Progresos",
                column: "id_materia",
                principalTable: "Materias",
                principalColumn: "id_materia",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
