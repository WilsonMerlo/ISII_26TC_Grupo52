using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudIA.Data.Migrations
{
    /// <inheritdoc />
    public partial class NivelesPomodoro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 501);

            migrationBuilder.AlterColumn<int>(
                name: "id_materia",
                table: "Pomodoros",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 1,
                columns: new[] { "id_apunte", "id_materia" },
                values: new object[] { 39, 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 2,
                columns: new[] { "id_apunte", "id_materia" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 3,
                column: "id_materia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 4,
                column: "id_materia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 5,
                columns: new[] { "id_apunte", "id_materia" },
                values: new object[] { 45, 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 6,
                column: "id_materia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 8,
                columns: new[] { "id_apunte", "id_materia" },
                values: new object[] { 23, 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 9,
                column: "id_materia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 10,
                columns: new[] { "id_apunte", "id_materia" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 11,
                columns: new[] { "id_apunte", "id_materia" },
                values: new object[] { 8, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 12,
                columns: new[] { "id_apunte", "id_materia" },
                values: new object[] { 39, 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 13,
                column: "id_materia",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 14,
                column: "id_materia",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 15,
                column: "id_materia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 16,
                column: "id_materia",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 17,
                columns: new[] { "id_apunte", "id_materia" },
                values: new object[] { 65, 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 18,
                column: "id_apunte",
                value: 99);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 20,
                column: "id_apunte",
                value: 52);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 21,
                column: "id_materia",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 22,
                column: "id_materia",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 23,
                column: "id_materia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 24,
                column: "id_materia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 25,
                column: "id_materia",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 26,
                columns: new[] { "id_apunte", "id_materia" },
                values: new object[] { 58, 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 27,
                column: "id_materia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 28,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 19, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 29,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 19, 14, 30, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 30,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 19, 15, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 31,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 5, 19, 15, 30, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 32,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 44, 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 33,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), 11, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 34,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 35,
                column: "fecha",
                value: new DateTime(2026, 5, 19, 17, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 36,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 5, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 37,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 19, 18, 30, 0, 0, DateTimeKind.Unspecified), 5, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 38,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 19, 14, 0, 0, 0, DateTimeKind.Unspecified), 63, 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 39,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 19, 14, 30, 0, 0, DateTimeKind.Unspecified), 92, 10, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 40,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 19, 15, 0, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 41,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 19, 15, 30, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 42,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 65, 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 43,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 44,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 5, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), 61 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 45,
                column: "fecha",
                value: new DateTime(2026, 5, 19, 17, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 46,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 47,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 19, 18, 30, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 48,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 19, 19, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 49,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 19, 19, 30, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 50,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 51,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 14, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 52,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 53,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 15, 30, 0, 0, DateTimeKind.Unspecified), 23, 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 54,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 55,
                column: "fecha",
                value: new DateTime(2026, 5, 20, 16, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 56,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 5, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 57,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 5, 20, 17, 30, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 58,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 59,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 18, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 60,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 19, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 61,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 19, 30, 0, 0, DateTimeKind.Unspecified), 25, 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 62,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 63,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 20, 14, 30, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 64,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), 83, 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 65,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 15, 30, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 66,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 84, 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 67,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 68,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), 75, 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 69,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 5, 20, 17, 30, 0, 0, DateTimeKind.Unspecified), 53 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 70,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 71,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 18, 30, 0, 0, DateTimeKind.Unspecified), 58, 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 72,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 14, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 73,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 14, 30, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 74,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 75,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 15, 30, 0, 0, DateTimeKind.Unspecified), 5, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 76,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 77,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 16, 30, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 78,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 79,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 21, 17, 30, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 80,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 81,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 21, 18, 30, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 82,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 14, 0, 0, 0, DateTimeKind.Unspecified), 63, 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 83,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 14, 30, 0, 0, DateTimeKind.Unspecified), 55, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 84,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 15, 0, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 85,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 15, 30, 0, 0, DateTimeKind.Unspecified), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 86,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 94, 10, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 87,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 16, 30, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 88,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 89,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 17, 30, 0, 0, DateTimeKind.Unspecified), 68, 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 90,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 91,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 21, 18, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 92,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 21, 19, 0, 0, 0, DateTimeKind.Unspecified), 74, 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 93,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 21, 19, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 94,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 95,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 14, 30, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 96,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 97,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 15, 30, 0, 0, DateTimeKind.Unspecified), 39, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 98,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 23, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 99,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 100,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), 5, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 101,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 17, 30, 0, 0, DateTimeKind.Unspecified), 8, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 102,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 103,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 22, 18, 30, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 104,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 22, 19, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 105,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 106,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 14, 30, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 107,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 108,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 15, 30, 0, 0, DateTimeKind.Unspecified), 74, 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 109,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 110,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), 98, 10, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 111,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), 72, 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 112,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 17, 30, 0, 0, DateTimeKind.Unspecified), 10, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 113,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 65, 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 114,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 18, 30, 0, 0, DateTimeKind.Unspecified), 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 115,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 22, 19, 0, 0, 0, DateTimeKind.Unspecified), 81, 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 116,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 22, 19, 30, 0, 0, DateTimeKind.Unspecified), 94, 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 117,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 118,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 14, 30, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 119,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 120,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 15, 30, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 121,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 122,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 16, 30, 0, 0, DateTimeKind.Unspecified), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 123,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), 14, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 124,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 17, 30, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 125,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 126,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 23, 18, 30, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 127,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 23, 19, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 128,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 129,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 14, 30, 0, 0, DateTimeKind.Unspecified), 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 130,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), 81, 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 131,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 15, 30, 0, 0, DateTimeKind.Unspecified), 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 132,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 133,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 16, 30, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 134,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), 96, 10, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 135,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 17, 30, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 136,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), 90, 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 137,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 23, 18, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 138,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 23, 19, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 139,
                column: "fecha",
                value: new DateTime(2026, 5, 23, 19, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 140,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 141,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 14, 30, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 142,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 143,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 15, 30, 0, 0, DateTimeKind.Unspecified), 28, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 144,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 145,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 16, 30, 0, 0, DateTimeKind.Unspecified), 38, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 146,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 147,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 17, 30, 0, 0, DateTimeKind.Unspecified), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 148,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 18, 0, 0, 0, DateTimeKind.Unspecified), 31, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 149,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 18, 30, 0, 0, DateTimeKind.Unspecified), 33, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 150,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 25, 19, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 151,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 25, 19, 30, 0, 0, DateTimeKind.Unspecified), 48, 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 152,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 153,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 14, 30, 0, 0, DateTimeKind.Unspecified), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 154,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), 86, 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 155,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 15, 30, 0, 0, DateTimeKind.Unspecified), 76, 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 156,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 89, 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 157,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 16, 30, 0, 0, DateTimeKind.Unspecified), 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 158,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 159,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 17, 30, 0, 0, DateTimeKind.Unspecified), 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 160,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 18, 0, 0, 0, DateTimeKind.Unspecified), 63, 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 161,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 18, 30, 0, 0, DateTimeKind.Unspecified), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 162,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 19, 0, 0, 0, DateTimeKind.Unspecified), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 163,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 5, 25, 19, 30, 0, 0, DateTimeKind.Unspecified), 99 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 164,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), 38, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 165,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 14, 30, 0, 0, DateTimeKind.Unspecified), 2, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 166,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 15, 0, 0, 0, DateTimeKind.Unspecified), 26, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 167,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 15, 30, 0, 0, DateTimeKind.Unspecified), 50, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 168,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 15, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 169,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 16, 30, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 170,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 171,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 17, 30, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 172,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 173,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 26, 18, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 174,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 26, 19, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 175,
                column: "fecha",
                value: new DateTime(2026, 5, 26, 19, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 176,
                column: "fecha",
                value: new DateTime(2026, 5, 26, 20, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 177,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), 71, 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 178,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 14, 30, 0, 0, DateTimeKind.Unspecified), 90, 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 179,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 15, 0, 0, 0, DateTimeKind.Unspecified), 10, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 180,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 15, 30, 0, 0, DateTimeKind.Unspecified), 97, 10, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 181,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 182,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 16, 30, 0, 0, DateTimeKind.Unspecified), 89, 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 183,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), 76, 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 184,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 26, 17, 30, 0, 0, DateTimeKind.Unspecified), 85, 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 185,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 186,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 5, 26, 18, 30, 0, 0, DateTimeKind.Unspecified), 84 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 187,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 26, 19, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 188,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 26, 19, 30, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 189,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), 41, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 190,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 27, 14, 30, 0, 0, DateTimeKind.Unspecified), 9, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 191,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 192,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 27, 15, 30, 0, 0, DateTimeKind.Unspecified), 35, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 193,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 194,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 27, 16, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 195,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), 16, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 196,
                column: "fecha",
                value: new DateTime(2026, 5, 27, 17, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 197,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), 8, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 198,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 27, 18, 30, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 199,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 27, 19, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 200,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), 64, 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 201,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 27, 14, 30, 0, 0, DateTimeKind.Unspecified), 65, 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 202,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 203,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 27, 15, 30, 0, 0, DateTimeKind.Unspecified), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 204,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 90, 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 205,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 27, 16, 30, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 206,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), 63, 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 207,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 27, 17, 30, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 208,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 209,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 27, 18, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 210,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 27, 19, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 211,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 27, 19, 30, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 212,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 213,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 28, 14, 30, 0, 0, DateTimeKind.Unspecified), 4, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 214,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), 23, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 215,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 28, 15, 30, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 216,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 217,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 28, 16, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 218,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), 8, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 219,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 28, 17, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 220,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 28, 18, 0, 0, 0, DateTimeKind.Unspecified), 23, 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 221,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 28, 18, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 222,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 28, 19, 0, 0, 0, DateTimeKind.Unspecified), 41, 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 223,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 28, 19, 30, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 224,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 28, 20, 0, 0, 0, DateTimeKind.Unspecified), 20, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 225,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 28, 20, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 227,
                columns: new[] { "id_apunte", "id_materia" },
                values: new object[] { 57, 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 228,
                column: "id_apunte",
                value: 97);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 229,
                column: "id_materia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 231,
                column: "id_materia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 233,
                column: "id_materia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 234,
                columns: new[] { "id_apunte", "id_materia" },
                values: new object[] { 76, 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 235,
                columns: new[] { "id_apunte", "id_materia" },
                values: new object[] { 95, 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 236,
                column: "id_apunte",
                value: 57);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 237,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 29, 14, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 238,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 5, 29, 14, 30, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 239,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 240,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 15, 30, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 241,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 21, 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 242,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 16, 30, 0, 0, DateTimeKind.Unspecified), 41, 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 243,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 17, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 244,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 17, 30, 0, 0, DateTimeKind.Unspecified), 27, 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 245,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 18, 0, 0, 0, DateTimeKind.Unspecified), 35, 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 246,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 18, 30, 0, 0, DateTimeKind.Unspecified), 14, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 247,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 19, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 248,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 19, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 249,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 29, 14, 0, 0, 0, DateTimeKind.Unspecified), 71, 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 250,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 29, 14, 30, 0, 0, DateTimeKind.Unspecified), 85, 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 251,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 252,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 15, 30, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 253,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 254,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 16, 30, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 255,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 17, 0, 0, 0, DateTimeKind.Unspecified), 58, 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 256,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 17, 30, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 257,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 18, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 258,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 18, 30, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 259,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 19, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 260,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), 44, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 261,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 30, 14, 30, 0, 0, DateTimeKind.Unspecified), 25, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 262,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 263,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 15, 30, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 264,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 265,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 5, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 266,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 267,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 5, 30, 17, 30, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 268,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 5, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 269,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 5, 30, 18, 30, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 270,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 19, 0, 0, 0, DateTimeKind.Unspecified), 17, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 271,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 19, 30, 0, 0, DateTimeKind.Unspecified), 22, 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 272,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), 20, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 273,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), 10, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 274,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 30, 14, 30, 0, 0, DateTimeKind.Unspecified), 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 275,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), 98, 10, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 276,
                column: "fecha",
                value: new DateTime(2026, 5, 30, 15, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 277,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 278,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 279,
                column: "fecha",
                value: new DateTime(2026, 5, 30, 17, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 280,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 17, 30, 0, 0, DateTimeKind.Unspecified), 51, 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 281,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), 68, 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 282,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 18, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 283,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 19, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 284,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 19, 30, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 285,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 286,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 29, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 287,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 288,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 289,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 15, 30, 0, 0, DateTimeKind.Unspecified), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 290,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 291,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 292,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 21, 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 293,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), 46, 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 294,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 295,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 18, 30, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 296,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 297,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 19, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 298,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 69, 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 299,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), 58, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 300,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 301,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 15, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 302,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 99, 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 303,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), 87, 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 304,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 305,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 306,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 6, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 83 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 307,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 18, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 308,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 309,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 19, 30, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 310,
                column: "fecha",
                value: new DateTime(2026, 6, 1, 20, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 311,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 312,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 2, 14, 30, 0, 0, DateTimeKind.Unspecified), 28, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 313,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 314,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 315,
                column: "fecha",
                value: new DateTime(2026, 6, 2, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 316,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 317,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 318,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 319,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 7, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 320,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 18, 30, 0, 0, DateTimeKind.Unspecified), 40, 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 321,
                column: "fecha",
                value: new DateTime(2026, 6, 2, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 322,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 323,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 2, 14, 30, 0, 0, DateTimeKind.Unspecified), 67, 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 324,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), 10, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 325,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 30, 0, 0, DateTimeKind.Unspecified), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 326,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 73, 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 327,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 328,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 329,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 30, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 330,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 331,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 18, 30, 0, 0, DateTimeKind.Unspecified), 93, 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 332,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 19, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 333,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 19, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 334,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 20, 0, 0, 0, DateTimeKind.Unspecified), 92, 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 335,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 20, 30, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 336,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 337,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 14, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 338,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 49, 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 339,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 15, 30, 0, 0, DateTimeKind.Unspecified), 24, 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 340,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 48, 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 341,
                column: "fecha",
                value: new DateTime(2026, 6, 3, 16, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 342,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 48, 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 343,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 17, 30, 0, 0, DateTimeKind.Unspecified), 26, 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 344,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 345,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 18, 30, 0, 0, DateTimeKind.Unspecified), 30, 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 346,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 19, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 347,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 19, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 348,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), 15, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 349,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 350,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 14, 30, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 351,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 352,
                column: "fecha",
                value: new DateTime(2026, 6, 3, 15, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 353,
                column: "fecha",
                value: new DateTime(2026, 6, 3, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 354,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), 72, 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 355,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 356,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 17, 30, 0, 0, DateTimeKind.Unspecified), 83, 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 357,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 358,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 18, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 359,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), 43, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 360,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 4, 14, 30, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 361,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 362,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 363,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 6, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 364,
                column: "fecha",
                value: new DateTime(2026, 6, 4, 16, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 365,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 366,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 6, 4, 17, 30, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 367,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 368,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 4, 18, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 369,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 4, 19, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 370,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 4, 19, 30, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 371,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), 10, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 372,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 4, 14, 30, 0, 0, DateTimeKind.Unspecified), 88, 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 373,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), 60, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 374,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 30, 0, 0, DateTimeKind.Unspecified), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 375,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 376,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 4, 16, 30, 0, 0, DateTimeKind.Unspecified), 94, 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 377,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 378,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 4, 17, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 379,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), 68, 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 380,
                column: "fecha",
                value: new DateTime(2026, 6, 4, 18, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 381,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 4, 19, 0, 0, 0, DateTimeKind.Unspecified), 67, 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 382,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 383,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 5, 14, 30, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 384,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), 41, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 385,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 5, 15, 30, 0, 0, DateTimeKind.Unspecified), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 386,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 387,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 39, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 388,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 389,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 5, 17, 30, 0, 0, DateTimeKind.Unspecified), 13, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 390,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), 15, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 391,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 30, 0, 0, DateTimeKind.Unspecified), 31, 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 392,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 5, 19, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 393,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 5, 19, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 394,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 395,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 396,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 5, 14, 30, 0, 0, DateTimeKind.Unspecified), 55, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 397,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 398,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 5, 15, 30, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 399,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 400,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 401,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 6, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), 74 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 402,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 5, 17, 30, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 403,
                column: "fecha",
                value: new DateTime(2026, 6, 5, 18, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 404,
                column: "fecha",
                value: new DateTime(2026, 6, 5, 18, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 405,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 406,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 6, 14, 30, 0, 0, DateTimeKind.Unspecified), 4, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 407,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), 42, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 408,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 6, 15, 30, 0, 0, DateTimeKind.Unspecified), 47, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 409,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 48, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 410,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 16, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 411,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 412,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 17, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 413,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 414,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 18, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 415,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 19, 0, 0, 0, DateTimeKind.Unspecified), 44, 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 416,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 19, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 417,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 20, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 418,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 20, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 419,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 420,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 6, 14, 30, 0, 0, DateTimeKind.Unspecified), 95, 10, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 421,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 422,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 6, 6, 15, 30, 0, 0, DateTimeKind.Unspecified), 52 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 423,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 424,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 16, 30, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 425,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 426,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 17, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 427,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 68, 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 428,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 18, 30, 0, 0, DateTimeKind.Unspecified), 62, 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 429,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 19, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 430,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 431,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 8, 14, 30, 0, 0, DateTimeKind.Unspecified), 3, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 432,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 433,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 8, 15, 30, 0, 0, DateTimeKind.Unspecified), 19, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 434,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 30, 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 435,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 35, 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 436,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), 10, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 437,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 438,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 439,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 18, 30, 0, 0, DateTimeKind.Unspecified), 36, 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 440,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), 80, 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 441,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 8, 14, 30, 0, 0, DateTimeKind.Unspecified), 88, 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 442,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 443,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 8, 15, 30, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 444,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 89, 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 445,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 446,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), 74, 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 447,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), 98, 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 448,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 73, 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 449,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 18, 30, 0, 0, DateTimeKind.Unspecified), 83, 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 450,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 19, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 451,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 19, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 452,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 453,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 454,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 30, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 455,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 456,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 9, 15, 30, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 457,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 48, 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 458,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 16, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 459,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), 21, 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 460,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 17, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 461,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 47, 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 462,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 18, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 463,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 19, 0, 0, 0, DateTimeKind.Unspecified), 19, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 464,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 465,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 30, 0, 0, DateTimeKind.Unspecified), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 466,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 467,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 9, 15, 30, 0, 0, DateTimeKind.Unspecified), 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 468,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 89, 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 469,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 16, 30, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 470,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 471,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 17, 30, 0, 0, DateTimeKind.Unspecified), 56, 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 472,
                column: "fecha",
                value: new DateTime(2026, 6, 9, 18, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 473,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 18, 30, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 474,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 19, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 475,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 19, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 476,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 477,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 6, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), 66 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 478,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), 38, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 479,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 14, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 480,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 6, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 481,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 15, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 482,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 483,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 16, 30, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 484,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), 10, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 485,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 17, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 486,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 19, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 487,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 18, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 488,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 489,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 19, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 490,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), 10, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 491,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 14, 30, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 492,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 493,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 15, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 494,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 495,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 16, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 496,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 497,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 6, 10, 17, 30, 0, 0, DateTimeKind.Unspecified), 94 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 498,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 499,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 18, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Progresos",
                keyColumn: "id_progreso",
                keyValue: 1,
                columns: new[] { "id_materia", "segundos_acumulados" },
                values: new object[] { 4, 45000 });

            migrationBuilder.UpdateData(
                table: "Progresos",
                keyColumn: "id_progreso",
                keyValue: 2,
                columns: new[] { "id_materia", "segundos_acumulados" },
                values: new object[] { 1, 70500 });

            migrationBuilder.UpdateData(
                table: "Progresos",
                keyColumn: "id_progreso",
                keyValue: 3,
                columns: new[] { "id_materia", "segundos_acumulados" },
                values: new object[] { 5, 49500 });

            migrationBuilder.UpdateData(
                table: "Progresos",
                keyColumn: "id_progreso",
                keyValue: 4,
                column: "segundos_acumulados",
                value: 76500);

            migrationBuilder.UpdateData(
                table: "Progresos",
                keyColumn: "id_progreso",
                keyValue: 5,
                columns: new[] { "id_materia", "segundos_acumulados" },
                values: new object[] { 6, 52500 });

            migrationBuilder.UpdateData(
                table: "Progresos",
                keyColumn: "id_progreso",
                keyValue: 6,
                column: "segundos_acumulados",
                value: 58500);

            migrationBuilder.UpdateData(
                table: "Progresos",
                keyColumn: "id_progreso",
                keyValue: 7,
                columns: new[] { "id_materia", "segundos_acumulados" },
                values: new object[] { 10, 46500 });

            migrationBuilder.UpdateData(
                table: "Progresos",
                keyColumn: "id_progreso",
                keyValue: 8,
                columns: new[] { "id_materia", "segundos_acumulados" },
                values: new object[] { 9, 61500 });

            migrationBuilder.UpdateData(
                table: "Progresos",
                keyColumn: "id_progreso",
                keyValue: 9,
                columns: new[] { "id_materia", "id_usuario", "segundos_acumulados" },
                values: new object[] { 2, 1, 49500 });

            migrationBuilder.UpdateData(
                table: "Progresos",
                keyColumn: "id_progreso",
                keyValue: 10,
                columns: new[] { "id_materia", "id_usuario", "segundos_acumulados" },
                values: new object[] { 8, 2, 57000 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "id_materia",
                table: "Pomodoros",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 1,
                columns: new[] { "id_apunte", "id_materia" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 2,
                columns: new[] { "id_apunte", "id_materia" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 3,
                column: "id_materia",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 4,
                column: "id_materia",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 5,
                columns: new[] { "id_apunte", "id_materia" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 6,
                column: "id_materia",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 8,
                columns: new[] { "id_apunte", "id_materia" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 9,
                column: "id_materia",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 10,
                columns: new[] { "id_apunte", "id_materia" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 11,
                columns: new[] { "id_apunte", "id_materia" },
                values: new object[] { null, 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 12,
                columns: new[] { "id_apunte", "id_materia" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 13,
                column: "id_materia",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 14,
                column: "id_materia",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 15,
                column: "id_materia",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 16,
                column: "id_materia",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 17,
                columns: new[] { "id_apunte", "id_materia" },
                values: new object[] { null, 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 18,
                column: "id_apunte",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 20,
                column: "id_apunte",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 21,
                column: "id_materia",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 22,
                column: "id_materia",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 23,
                column: "id_materia",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 24,
                column: "id_materia",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 25,
                column: "id_materia",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 26,
                columns: new[] { "id_apunte", "id_materia" },
                values: new object[] { null, 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 27,
                column: "id_materia",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 28,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 18, 20, 30, 0, 0, DateTimeKind.Unspecified), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 29,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 19, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 30,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 19, 14, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 31,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 5, 19, 15, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 32,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 19, 15, 30, 0, 0, DateTimeKind.Unspecified), null, 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 33,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 34,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 35,
                column: "fecha",
                value: new DateTime(2026, 5, 19, 17, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 36,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 5, 19, 17, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 37,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), null, 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 38,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 19, 18, 30, 0, 0, DateTimeKind.Unspecified), null, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 39,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 19, 19, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 40,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 19, 19, 30, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 41,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 19, 14, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 42,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 19, 14, 30, 0, 0, DateTimeKind.Unspecified), null, 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 43,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 19, 15, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 44,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 5, 19, 15, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 45,
                column: "fecha",
                value: new DateTime(2026, 5, 19, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 46,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 47,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 48,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 19, 17, 30, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 49,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 50,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 19, 18, 30, 0, 0, DateTimeKind.Unspecified), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 51,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 52,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 14, 30, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 53,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), null, 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 54,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 15, 30, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 55,
                column: "fecha",
                value: new DateTime(2026, 5, 20, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 56,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 5, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 57,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 5, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 58,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 17, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 59,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 60,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 18, 30, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 61,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 19, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 62,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 20, 19, 30, 0, 0, DateTimeKind.Unspecified), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 63,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 64,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 20, 20, 30, 0, 0, DateTimeKind.Unspecified), null, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 65,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 66,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 14, 30, 0, 0, DateTimeKind.Unspecified), null, 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 67,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 68,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 15, 30, 0, 0, DateTimeKind.Unspecified), null, 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 69,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 5, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 70,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 71,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 72,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 20, 17, 30, 0, 0, DateTimeKind.Unspecified), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 73,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 74,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 20, 18, 30, 0, 0, DateTimeKind.Unspecified), null, 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 75,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 20, 19, 0, 0, 0, DateTimeKind.Unspecified), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 76,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 20, 19, 30, 0, 0, DateTimeKind.Unspecified), 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 77,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 78,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 20, 20, 30, 0, 0, DateTimeKind.Unspecified), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 79,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 21, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 80,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 21, 14, 30, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 81,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 21, 15, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 82,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 15, 30, 0, 0, DateTimeKind.Unspecified), null, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 83,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 84,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 16, 30, 0, 0, DateTimeKind.Unspecified), 5, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 85,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 86,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 17, 30, 0, 0, DateTimeKind.Unspecified), null, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 87,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 88,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 18, 30, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 89,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 19, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 90,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 19, 30, 0, 0, DateTimeKind.Unspecified), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 91,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 21, 14, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 92,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 21, 14, 30, 0, 0, DateTimeKind.Unspecified), null, 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 93,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 21, 15, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 94,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 15, 30, 0, 0, DateTimeKind.Unspecified), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 95,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 96,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 16, 30, 0, 0, DateTimeKind.Unspecified), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 97,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 98,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 17, 30, 0, 0, DateTimeKind.Unspecified), null, 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 99,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 100,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 18, 30, 0, 0, DateTimeKind.Unspecified), 10, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 101,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 19, 0, 0, 0, DateTimeKind.Unspecified), null, 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 102,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 21, 19, 30, 0, 0, DateTimeKind.Unspecified), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 103,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 22, 14, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 104,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 22, 14, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 105,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 106,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 15, 30, 0, 0, DateTimeKind.Unspecified), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 107,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 108,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), null, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 109,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 110,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 17, 30, 0, 0, DateTimeKind.Unspecified), null, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 111,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 112,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 18, 30, 0, 0, DateTimeKind.Unspecified), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 113,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 19, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 114,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 19, 30, 0, 0, DateTimeKind.Unspecified), 5, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 115,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 22, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 116,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 22, 14, 30, 0, 0, DateTimeKind.Unspecified), null, 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 117,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 118,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 15, 30, 0, 0, DateTimeKind.Unspecified), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 119,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), null, 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 120,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 121,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 122,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 17, 30, 0, 0, DateTimeKind.Unspecified), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 123,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), null, 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 124,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 18, 30, 0, 0, DateTimeKind.Unspecified), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 125,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 22, 19, 0, 0, 0, DateTimeKind.Unspecified), 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 126,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 127,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 23, 14, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 128,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 129,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 15, 30, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 130,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 131,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 16, 30, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 132,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 133,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 17, 30, 0, 0, DateTimeKind.Unspecified), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 134,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 135,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 18, 30, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 136,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 19, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 137,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 138,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 23, 14, 30, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 139,
                column: "fecha",
                value: new DateTime(2026, 5, 23, 15, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 140,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 15, 30, 0, 0, DateTimeKind.Unspecified), 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 141,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 10, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 142,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 16, 30, 0, 0, DateTimeKind.Unspecified), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 143,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 144,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 17, 30, 0, 0, DateTimeKind.Unspecified), 10, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 145,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 146,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 18, 30, 0, 0, DateTimeKind.Unspecified), 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 147,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 19, 0, 0, 0, DateTimeKind.Unspecified), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 148,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 19, 30, 0, 0, DateTimeKind.Unspecified), null, 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 149,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 150,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 151,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 25, 14, 30, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 152,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 153,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 15, 30, 0, 0, DateTimeKind.Unspecified), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 154,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 155,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 16, 30, 0, 0, DateTimeKind.Unspecified), null, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 156,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 157,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 17, 30, 0, 0, DateTimeKind.Unspecified), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 158,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 159,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 18, 30, 0, 0, DateTimeKind.Unspecified), 5, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 160,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 19, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 161,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 19, 30, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 162,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 163,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 5, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 164,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 14, 30, 0, 0, DateTimeKind.Unspecified), null, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 165,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 166,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 15, 30, 0, 0, DateTimeKind.Unspecified), null, 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 167,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 168,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 16, 30, 0, 0, DateTimeKind.Unspecified), null, 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 169,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), 10, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 170,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 17, 30, 0, 0, DateTimeKind.Unspecified), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 171,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 18, 0, 0, 0, DateTimeKind.Unspecified), 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 172,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 25, 18, 30, 0, 0, DateTimeKind.Unspecified), 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 173,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 174,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 26, 14, 30, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 175,
                column: "fecha",
                value: new DateTime(2026, 5, 26, 15, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 176,
                column: "fecha",
                value: new DateTime(2026, 5, 26, 15, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 177,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 178,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 16, 30, 0, 0, DateTimeKind.Unspecified), null, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 179,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 180,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 17, 30, 0, 0, DateTimeKind.Unspecified), null, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 181,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 182,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 18, 30, 0, 0, DateTimeKind.Unspecified), null, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 183,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 19, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 184,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 185,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 26, 14, 30, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 186,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 5, 26, 15, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 187,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 26, 15, 30, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 188,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 189,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 16, 30, 0, 0, DateTimeKind.Unspecified), null, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 190,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 191,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 17, 30, 0, 0, DateTimeKind.Unspecified), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 192,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), null, 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 193,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 26, 18, 30, 0, 0, DateTimeKind.Unspecified), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 194,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 195,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 27, 14, 30, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 196,
                column: "fecha",
                value: new DateTime(2026, 5, 27, 15, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 197,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 27, 15, 30, 0, 0, DateTimeKind.Unspecified), null, 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 198,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 199,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 27, 16, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 200,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 201,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 27, 17, 30, 0, 0, DateTimeKind.Unspecified), null, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 202,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 203,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 27, 18, 30, 0, 0, DateTimeKind.Unspecified), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 204,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 27, 19, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 205,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 206,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 27, 14, 30, 0, 0, DateTimeKind.Unspecified), null, 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 207,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 208,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 27, 15, 30, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 209,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 210,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 27, 16, 30, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 211,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 212,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 27, 17, 30, 0, 0, DateTimeKind.Unspecified), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 213,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 214,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 27, 18, 30, 0, 0, DateTimeKind.Unspecified), null, 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 215,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 27, 19, 0, 0, 0, DateTimeKind.Unspecified), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 216,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 217,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 28, 14, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 218,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), null, 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 219,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 28, 15, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 220,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 221,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 28, 16, 30, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 222,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 223,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 28, 17, 30, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 224,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 28, 18, 0, 0, 0, DateTimeKind.Unspecified), null, 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 225,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 28, 18, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 227,
                columns: new[] { "id_apunte", "id_materia" },
                values: new object[] { null, 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 228,
                column: "id_apunte",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 229,
                column: "id_materia",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 231,
                column: "id_materia",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 233,
                column: "id_materia",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 234,
                columns: new[] { "id_apunte", "id_materia" },
                values: new object[] { null, 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 235,
                columns: new[] { "id_apunte", "id_materia" },
                values: new object[] { null, 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 236,
                column: "id_apunte",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 237,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 28, 19, 30, 0, 0, DateTimeKind.Unspecified), 10, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 238,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 5, 29, 14, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 239,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 14, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 240,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 241,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 15, 30, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 242,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), null, 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 243,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 16, 30, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 244,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 245,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 17, 30, 0, 0, DateTimeKind.Unspecified), null, 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 246,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 18, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 247,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 18, 30, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 248,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 19, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 249,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 29, 19, 30, 0, 0, DateTimeKind.Unspecified), null, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 250,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 29, 20, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 251,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 29, 20, 30, 0, 0, DateTimeKind.Unspecified), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 252,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 14, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 253,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 14, 30, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 254,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 255,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 15, 30, 0, 0, DateTimeKind.Unspecified), null, 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 256,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 257,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 16, 30, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 258,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 17, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 259,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 29, 17, 30, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 260,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 29, 18, 0, 0, 0, DateTimeKind.Unspecified), null, 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 261,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 29, 18, 30, 0, 0, DateTimeKind.Unspecified), null, 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 262,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 29, 19, 0, 0, 0, DateTimeKind.Unspecified), 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 263,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 264,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 14, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 265,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 5, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 266,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 15, 30, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 267,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 5, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 268,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 5, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 269,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 5, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 270,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 17, 30, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 271,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), null, 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 272,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 18, 30, 0, 0, DateTimeKind.Unspecified), null, 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 273,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 30, 19, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 274,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 30, 19, 30, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 275,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 276,
                column: "fecha",
                value: new DateTime(2026, 5, 30, 14, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 277,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 14, 30, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 278,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 279,
                column: "fecha",
                value: new DateTime(2026, 5, 30, 15, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 280,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), null, 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 281,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), null, 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 282,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 283,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 17, 30, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 284,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 285,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 5, 30, 18, 30, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 286,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 30, 19, 0, 0, 0, DateTimeKind.Unspecified), null, 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 287,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 30, 19, 30, 0, 0, DateTimeKind.Unspecified), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 288,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 5, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 289,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 290,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 291,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 292,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 15, 30, 0, 0, DateTimeKind.Unspecified), null, 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 293,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), null, 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 294,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 295,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 296,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 297,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 298,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 1, 18, 30, 0, 0, DateTimeKind.Unspecified), null, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 299,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 300,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 1, 19, 30, 0, 0, DateTimeKind.Unspecified), 5, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 301,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 302,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), null, 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 303,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), null, 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 304,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 15, 30, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 305,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 306,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 6, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 307,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 308,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 309,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 310,
                column: "fecha",
                value: new DateTime(2026, 6, 1, 18, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 311,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 312,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 1, 19, 30, 0, 0, DateTimeKind.Unspecified), null, 10, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 313,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 314,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 315,
                column: "fecha",
                value: new DateTime(2026, 6, 2, 14, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 316,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 317,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 318,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 319,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), null, 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 320,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 321,
                column: "fecha",
                value: new DateTime(2026, 6, 2, 17, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 322,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 323,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 2, 18, 30, 0, 0, DateTimeKind.Unspecified), null, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 324,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 2, 19, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 325,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 2, 19, 30, 0, 0, DateTimeKind.Unspecified), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 326,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 327,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 14, 30, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 328,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 329,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 15, 30, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 330,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 331,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), null, 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 332,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 333,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 17, 30, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 334,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), null, 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 335,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 2, 18, 30, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 336,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 2, 19, 0, 0, 0, DateTimeKind.Unspecified), 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 337,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 338,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 14, 30, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 339,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 340,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 15, 30, 0, 0, DateTimeKind.Unspecified), null, 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 341,
                column: "fecha",
                value: new DateTime(2026, 6, 3, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 342,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), null, 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 343,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 344,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 17, 30, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 345,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), null, 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 346,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 18, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 347,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 19, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 348,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 19, 30, 0, 0, DateTimeKind.Unspecified), null, 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 349,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 350,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 351,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 14, 30, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 352,
                column: "fecha",
                value: new DateTime(2026, 6, 3, 15, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 353,
                column: "fecha",
                value: new DateTime(2026, 6, 3, 15, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 354,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), null, 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 355,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 356,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 357,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 17, 30, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 358,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 359,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 3, 18, 30, 0, 0, DateTimeKind.Unspecified), null, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 360,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 3, 19, 0, 0, 0, DateTimeKind.Unspecified), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 361,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 6, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 362,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 4, 14, 30, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 363,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 364,
                column: "fecha",
                value: new DateTime(2026, 6, 4, 15, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 365,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 366,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 6, 4, 16, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 367,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 368,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 4, 17, 30, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 369,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 370,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 4, 18, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 371,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 4, 19, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 372,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 4, 19, 30, 0, 0, DateTimeKind.Unspecified), null, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 373,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 4, 20, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 374,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 4, 20, 30, 0, 0, DateTimeKind.Unspecified), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 375,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 376,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 4, 14, 30, 0, 0, DateTimeKind.Unspecified), null, 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 377,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 378,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 30, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 379,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), null, 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 380,
                column: "fecha",
                value: new DateTime(2026, 6, 4, 16, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 381,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 382,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 4, 17, 30, 0, 0, DateTimeKind.Unspecified), 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 383,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 384,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 4, 18, 30, 0, 0, DateTimeKind.Unspecified), null, 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 385,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 4, 19, 0, 0, 0, DateTimeKind.Unspecified), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 386,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 4, 19, 30, 0, 0, DateTimeKind.Unspecified), 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 387,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 4, 20, 0, 0, 0, DateTimeKind.Unspecified), null, 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 388,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 4, 20, 30, 0, 0, DateTimeKind.Unspecified), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 389,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 390,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 5, 14, 30, 0, 0, DateTimeKind.Unspecified), null, 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 391,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 392,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 5, 15, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 393,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 394,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 395,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 396,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 5, 17, 30, 0, 0, DateTimeKind.Unspecified), null, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 397,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 398,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 30, 0, 0, DateTimeKind.Unspecified), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 399,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 5, 19, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 400,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 401,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 6, 5, 14, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 402,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 403,
                column: "fecha",
                value: new DateTime(2026, 6, 5, 15, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 404,
                column: "fecha",
                value: new DateTime(2026, 6, 5, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 405,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 406,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 407,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 5, 17, 30, 0, 0, DateTimeKind.Unspecified), null, 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 408,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 409,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 30, 0, 0, DateTimeKind.Unspecified), null, 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 410,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 411,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 14, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 412,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 413,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 15, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 414,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 415,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 16, 30, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 416,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 417,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 17, 30, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 418,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 419,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 6, 18, 30, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 420,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 6, 19, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 421,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 422,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 6, 6, 14, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 423,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 424,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 15, 30, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 425,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 426,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 16, 30, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 427,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 428,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 17, 30, 0, 0, DateTimeKind.Unspecified), null, 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 429,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 430,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 6, 18, 30, 0, 0, DateTimeKind.Unspecified), 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 431,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 6, 19, 0, 0, 0, DateTimeKind.Unspecified), null, 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 432,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 6, 19, 30, 0, 0, DateTimeKind.Unspecified), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 433,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 6, 20, 0, 0, 0, DateTimeKind.Unspecified), null, 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 434,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 435,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 14, 30, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 436,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), null, 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 437,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 15, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 438,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 439,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 440,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 441,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), null, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 442,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 443,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 8, 18, 30, 0, 0, DateTimeKind.Unspecified), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 444,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 445,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 14, 30, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 446,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), null, 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 447,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 15, 30, 0, 0, DateTimeKind.Unspecified), null, 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 448,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), null, 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 449,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), null, 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 450,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 451,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 452,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 453,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 8, 18, 30, 0, 0, DateTimeKind.Unspecified), 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 454,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 8, 19, 0, 0, 0, DateTimeKind.Unspecified), 7, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 455,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 8, 19, 30, 0, 0, DateTimeKind.Unspecified), 9, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 456,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 457,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 458,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 30, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 459,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), null, 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 460,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 15, 30, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 461,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), null, 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 462,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 16, 30, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 463,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 464,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 9, 17, 30, 0, 0, DateTimeKind.Unspecified), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 465,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 466,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 9, 18, 30, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 467,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 9, 19, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 468,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 469,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 30, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 470,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 471,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 15, 30, 0, 0, DateTimeKind.Unspecified), null, 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 472,
                column: "fecha",
                value: new DateTime(2026, 6, 9, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 473,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 16, 30, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 474,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 475,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 17, 30, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 476,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 477,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 6, 9, 18, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 478,
                columns: new[] { "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 9, 19, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 479,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 480,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 6, 10, 14, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 481,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 482,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 15, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 483,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 484,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 16, 30, 0, 0, DateTimeKind.Unspecified), null, 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 485,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 486,
                columns: new[] { "fecha", "id_apunte", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 17, 30, 0, 0, DateTimeKind.Unspecified), null, 3 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 487,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 488,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 18, 30, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 489,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 490,
                columns: new[] { "fecha", "id_materia", "id_usuario" },
                values: new object[] { new DateTime(2026, 6, 10, 19, 30, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 491,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 492,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 14, 30, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 493,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 494,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 15, 30, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 495,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 496,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 16, 30, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 497,
                columns: new[] { "fecha", "id_apunte" },
                values: new object[] { new DateTime(2026, 6, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 498,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 17, 30, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 499,
                columns: new[] { "fecha", "id_materia" },
                values: new object[] { new DateTime(2026, 6, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.InsertData(
                table: "Pomodoros",
                columns: new[] { "id_pomodoro", "duracion_descanso", "duracion_estudio", "estado_fase", "fecha", "id_apunte", "id_materia", "id_usuario" },
                values: new object[,]
                {
                    { 500, 300, 1500, 4, new DateTime(2026, 6, 10, 18, 30, 0, 0, DateTimeKind.Unspecified), null, 6, 2 },
                    { 501, 300, 1500, 4, new DateTime(2026, 6, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), null, 10, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Progresos",
                keyColumn: "id_progreso",
                keyValue: 1,
                columns: new[] { "id_materia", "segundos_acumulados" },
                values: new object[] { 5, 72000 });

            migrationBuilder.UpdateData(
                table: "Progresos",
                keyColumn: "id_progreso",
                keyValue: 2,
                columns: new[] { "id_materia", "segundos_acumulados" },
                values: new object[] { 4, 75000 });

            migrationBuilder.UpdateData(
                table: "Progresos",
                keyColumn: "id_progreso",
                keyValue: 3,
                columns: new[] { "id_materia", "segundos_acumulados" },
                values: new object[] { 1, 93000 });

            migrationBuilder.UpdateData(
                table: "Progresos",
                keyColumn: "id_progreso",
                keyValue: 4,
                column: "segundos_acumulados",
                value: 75000);

            migrationBuilder.UpdateData(
                table: "Progresos",
                keyColumn: "id_progreso",
                keyValue: 5,
                columns: new[] { "id_materia", "segundos_acumulados" },
                values: new object[] { 8, 91500 });

            migrationBuilder.UpdateData(
                table: "Progresos",
                keyColumn: "id_progreso",
                keyValue: 6,
                column: "segundos_acumulados",
                value: 70500);

            migrationBuilder.UpdateData(
                table: "Progresos",
                keyColumn: "id_progreso",
                keyValue: 7,
                columns: new[] { "id_materia", "segundos_acumulados" },
                values: new object[] { 6, 90000 });

            migrationBuilder.UpdateData(
                table: "Progresos",
                keyColumn: "id_progreso",
                keyValue: 8,
                columns: new[] { "id_materia", "segundos_acumulados" },
                values: new object[] { 10, 51000 });

            migrationBuilder.UpdateData(
                table: "Progresos",
                keyColumn: "id_progreso",
                keyValue: 9,
                columns: new[] { "id_materia", "id_usuario", "segundos_acumulados" },
                values: new object[] { 9, 2, 69000 });

            migrationBuilder.UpdateData(
                table: "Progresos",
                keyColumn: "id_progreso",
                keyValue: 10,
                columns: new[] { "id_materia", "id_usuario", "segundos_acumulados" },
                values: new object[] { 2, 1, 64500 });
        }
    }
}
