using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudIA.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigracionDiccionarioDatosV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    id_usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    correo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    contraseña = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.id_usuario);
                });

            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    id_materia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_usuario = table.Column<int>(type: "int", nullable: false),
                    nombre_materia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.id_materia);
                    table.ForeignKey(
                        name: "FK_Materias_Usuarios_id_usuario",
                        column: x => x.id_usuario,
                        principalTable: "Usuarios",
                        principalColumn: "id_usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Apuntes",
                columns: table => new
                {
                    id_apunte = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_materia = table.Column<int>(type: "int", nullable: false),
                    titulo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    contenido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apuntes", x => x.id_apunte);
                    table.ForeignKey(
                        name: "FK_Apuntes_Materias_id_materia",
                        column: x => x.id_materia,
                        principalTable: "Materias",
                        principalColumn: "id_materia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Progresos",
                columns: table => new
                {
                    id_progreso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_usuario = table.Column<int>(type: "int", nullable: false),
                    id_materia = table.Column<int>(type: "int", nullable: false),
                    avance_porcentual = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Progresos", x => x.id_progreso);
                    table.ForeignKey(
                        name: "FK_Progresos_Materias_id_materia",
                        column: x => x.id_materia,
                        principalTable: "Materias",
                        principalColumn: "id_materia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Progresos_Usuarios_id_usuario",
                        column: x => x.id_usuario,
                        principalTable: "Usuarios",
                        principalColumn: "id_usuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pomodoros",
                columns: table => new
                {
                    id_pomodoro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_usuario = table.Column<int>(type: "int", nullable: false),
                    id_materia = table.Column<int>(type: "int", nullable: false),
                    id_apunte = table.Column<int>(type: "int", nullable: true),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    duracion_estudio = table.Column<int>(type: "int", nullable: false),
                    duracion_descanso = table.Column<int>(type: "int", nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pomodoros", x => x.id_pomodoro);
                    table.ForeignKey(
                        name: "FK_Pomodoros_Apuntes_id_apunte",
                        column: x => x.id_apunte,
                        principalTable: "Apuntes",
                        principalColumn: "id_apunte");
                    table.ForeignKey(
                        name: "FK_Pomodoros_Materias_id_materia",
                        column: x => x.id_materia,
                        principalTable: "Materias",
                        principalColumn: "id_materia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pomodoros_Usuarios_id_usuario",
                        column: x => x.id_usuario,
                        principalTable: "Usuarios",
                        principalColumn: "id_usuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "id_usuario", "contraseña", "correo", "nombre" },
                values: new object[] { 1, "1234", "wilson@test.com", "Wilson Merlo" });

            migrationBuilder.InsertData(
                table: "Materias",
                columns: new[] { "id_materia", "descripcion", "id_usuario", "nombre_materia" },
                values: new object[,]
                {
                    { 1, "Proyecto StudIA", 1, "Ingeniería de Software II" },
                    { 2, "Preparación de finales", 1, "Cálculo" },
                    { 3, "Modelos probabilísticos", 1, "Estadística" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apuntes_id_materia",
                table: "Apuntes",
                column: "id_materia");

            migrationBuilder.CreateIndex(
                name: "IX_Materias_id_usuario",
                table: "Materias",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Pomodoros_id_apunte",
                table: "Pomodoros",
                column: "id_apunte");

            migrationBuilder.CreateIndex(
                name: "IX_Pomodoros_id_materia",
                table: "Pomodoros",
                column: "id_materia");

            migrationBuilder.CreateIndex(
                name: "IX_Pomodoros_id_usuario",
                table: "Pomodoros",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Progresos_id_materia",
                table: "Progresos",
                column: "id_materia");

            migrationBuilder.CreateIndex(
                name: "IX_Progresos_id_usuario",
                table: "Progresos",
                column: "id_usuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pomodoros");

            migrationBuilder.DropTable(
                name: "Progresos");

            migrationBuilder.DropTable(
                name: "Apuntes");

            migrationBuilder.DropTable(
                name: "Materias");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
