using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudIA.Data.Migrations
{
    /// <inheritdoc />
    public partial class PatronState : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "estado",
                table: "Pomodoros");

            migrationBuilder.AddColumn<int>(
                name: "estado_fase",
                table: "Pomodoros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 1,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 2,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 3,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 4,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 5,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 6,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 7,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 8,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 9,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 10,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 11,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 12,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 13,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 14,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 15,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 16,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 17,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 18,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 19,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 20,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 21,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 22,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 23,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 24,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 25,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 26,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 27,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 28,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 29,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 30,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 31,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 32,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 33,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 34,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 35,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 36,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 37,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 38,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 39,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 40,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 41,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 42,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 43,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 44,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 45,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 46,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 47,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 48,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 49,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 50,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 51,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 52,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 53,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 54,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 55,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 56,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 57,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 58,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 59,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 60,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 61,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 62,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 63,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 64,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 65,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 66,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 67,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 68,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 69,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 70,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 71,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 72,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 73,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 74,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 75,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 76,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 77,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 78,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 79,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 80,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 81,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 82,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 83,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 84,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 85,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 86,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 87,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 88,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 89,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 90,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 91,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 92,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 93,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 94,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 95,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 96,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 97,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 98,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 99,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 100,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 101,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 102,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 103,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 104,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 105,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 106,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 107,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 108,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 109,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 110,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 111,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 112,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 113,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 114,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 115,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 116,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 117,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 118,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 119,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 120,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 121,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 122,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 123,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 124,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 125,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 126,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 127,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 128,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 129,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 130,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 131,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 132,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 133,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 134,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 135,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 136,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 137,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 138,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 139,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 140,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 141,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 142,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 143,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 144,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 145,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 146,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 147,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 148,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 149,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 150,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 151,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 152,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 153,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 154,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 155,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 156,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 157,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 158,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 159,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 160,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 161,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 162,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 163,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 164,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 165,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 166,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 167,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 168,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 169,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 170,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 171,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 172,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 173,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 174,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 175,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 176,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 177,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 178,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 179,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 180,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 181,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 182,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 183,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 184,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 185,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 186,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 187,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 188,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 189,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 190,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 191,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 192,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 193,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 194,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 195,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 196,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 197,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 198,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 199,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 200,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 201,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 202,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 203,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 204,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 205,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 206,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 207,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 208,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 209,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 210,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 211,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 212,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 213,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 214,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 215,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 216,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 217,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 218,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 219,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 220,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 221,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 222,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 223,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 224,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 225,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 226,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 227,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 228,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 229,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 230,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 231,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 232,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 233,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 234,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 235,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 236,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 237,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 238,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 239,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 240,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 241,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 242,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 243,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 244,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 245,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 246,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 247,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 248,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 249,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 250,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 251,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 252,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 253,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 254,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 255,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 256,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 257,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 258,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 259,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 260,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 261,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 262,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 263,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 264,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 265,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 266,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 267,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 268,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 269,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 270,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 271,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 272,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 273,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 274,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 275,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 276,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 277,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 278,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 279,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 280,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 281,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 282,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 283,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 284,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 285,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 286,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 287,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 288,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 289,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 290,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 291,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 292,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 293,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 294,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 295,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 296,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 297,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 298,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 299,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 300,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 301,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 302,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 303,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 304,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 305,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 306,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 307,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 308,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 309,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 310,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 311,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 312,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 313,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 314,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 315,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 316,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 317,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 318,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 319,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 320,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 321,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 322,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 323,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 324,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 325,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 326,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 327,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 328,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 329,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 330,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 331,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 332,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 333,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 334,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 335,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 336,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 337,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 338,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 339,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 340,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 341,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 342,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 343,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 344,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 345,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 346,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 347,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 348,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 349,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 350,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 351,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 352,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 353,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 354,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 355,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 356,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 357,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 358,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 359,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 360,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 361,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 362,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 363,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 364,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 365,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 366,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 367,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 368,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 369,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 370,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 371,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 372,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 373,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 374,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 375,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 376,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 377,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 378,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 379,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 380,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 381,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 382,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 383,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 384,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 385,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 386,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 387,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 388,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 389,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 390,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 391,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 392,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 393,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 394,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 395,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 396,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 397,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 398,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 399,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 400,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 401,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 402,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 403,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 404,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 405,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 406,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 407,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 408,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 409,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 410,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 411,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 412,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 413,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 414,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 415,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 416,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 417,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 418,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 419,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 420,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 421,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 422,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 423,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 424,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 425,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 426,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 427,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 428,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 429,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 430,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 431,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 432,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 433,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 434,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 435,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 436,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 437,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 438,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 439,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 440,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 441,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 442,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 443,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 444,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 445,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 446,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 447,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 448,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 449,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 450,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 451,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 452,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 453,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 454,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 455,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 456,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 457,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 458,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 459,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 460,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 461,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 462,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 463,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 464,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 465,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 466,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 467,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 468,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 469,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 470,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 471,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 472,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 473,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 474,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 475,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 476,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 477,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 478,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 479,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 480,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 481,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 482,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 483,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 484,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 485,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 486,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 487,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 488,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 489,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 490,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 491,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 492,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 493,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 494,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 495,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 496,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 497,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 498,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 499,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 500,
                column: "estado_fase",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 501,
                column: "estado_fase",
                value: 4);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "estado_fase",
                table: "Pomodoros");

            migrationBuilder.AddColumn<bool>(
                name: "estado",
                table: "Pomodoros",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 1,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 2,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 3,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 4,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 5,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 6,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 7,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 8,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 9,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 10,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 11,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 12,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 13,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 14,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 15,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 16,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 17,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 18,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 19,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 20,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 21,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 22,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 23,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 24,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 25,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 26,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 27,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 28,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 29,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 30,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 31,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 32,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 33,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 34,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 35,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 36,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 37,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 38,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 39,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 40,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 41,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 42,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 43,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 44,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 45,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 46,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 47,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 48,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 49,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 50,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 51,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 52,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 53,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 54,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 55,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 56,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 57,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 58,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 59,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 60,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 61,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 62,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 63,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 64,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 65,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 66,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 67,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 68,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 69,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 70,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 71,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 72,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 73,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 74,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 75,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 76,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 77,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 78,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 79,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 80,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 81,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 82,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 83,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 84,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 85,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 86,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 87,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 88,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 89,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 90,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 91,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 92,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 93,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 94,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 95,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 96,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 97,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 98,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 99,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 100,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 101,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 102,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 103,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 104,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 105,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 106,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 107,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 108,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 109,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 110,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 111,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 112,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 113,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 114,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 115,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 116,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 117,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 118,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 119,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 120,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 121,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 122,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 123,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 124,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 125,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 126,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 127,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 128,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 129,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 130,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 131,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 132,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 133,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 134,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 135,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 136,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 137,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 138,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 139,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 140,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 141,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 142,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 143,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 144,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 145,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 146,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 147,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 148,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 149,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 150,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 151,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 152,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 153,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 154,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 155,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 156,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 157,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 158,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 159,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 160,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 161,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 162,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 163,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 164,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 165,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 166,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 167,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 168,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 169,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 170,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 171,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 172,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 173,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 174,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 175,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 176,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 177,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 178,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 179,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 180,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 181,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 182,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 183,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 184,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 185,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 186,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 187,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 188,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 189,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 190,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 191,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 192,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 193,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 194,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 195,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 196,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 197,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 198,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 199,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 200,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 201,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 202,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 203,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 204,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 205,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 206,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 207,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 208,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 209,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 210,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 211,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 212,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 213,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 214,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 215,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 216,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 217,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 218,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 219,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 220,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 221,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 222,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 223,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 224,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 225,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 226,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 227,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 228,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 229,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 230,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 231,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 232,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 233,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 234,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 235,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 236,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 237,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 238,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 239,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 240,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 241,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 242,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 243,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 244,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 245,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 246,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 247,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 248,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 249,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 250,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 251,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 252,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 253,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 254,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 255,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 256,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 257,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 258,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 259,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 260,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 261,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 262,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 263,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 264,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 265,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 266,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 267,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 268,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 269,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 270,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 271,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 272,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 273,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 274,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 275,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 276,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 277,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 278,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 279,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 280,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 281,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 282,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 283,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 284,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 285,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 286,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 287,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 288,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 289,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 290,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 291,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 292,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 293,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 294,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 295,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 296,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 297,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 298,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 299,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 300,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 301,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 302,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 303,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 304,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 305,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 306,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 307,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 308,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 309,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 310,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 311,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 312,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 313,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 314,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 315,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 316,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 317,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 318,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 319,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 320,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 321,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 322,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 323,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 324,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 325,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 326,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 327,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 328,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 329,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 330,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 331,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 332,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 333,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 334,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 335,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 336,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 337,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 338,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 339,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 340,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 341,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 342,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 343,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 344,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 345,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 346,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 347,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 348,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 349,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 350,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 351,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 352,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 353,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 354,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 355,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 356,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 357,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 358,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 359,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 360,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 361,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 362,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 363,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 364,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 365,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 366,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 367,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 368,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 369,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 370,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 371,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 372,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 373,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 374,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 375,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 376,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 377,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 378,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 379,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 380,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 381,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 382,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 383,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 384,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 385,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 386,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 387,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 388,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 389,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 390,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 391,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 392,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 393,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 394,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 395,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 396,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 397,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 398,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 399,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 400,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 401,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 402,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 403,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 404,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 405,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 406,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 407,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 408,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 409,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 410,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 411,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 412,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 413,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 414,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 415,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 416,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 417,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 418,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 419,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 420,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 421,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 422,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 423,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 424,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 425,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 426,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 427,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 428,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 429,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 430,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 431,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 432,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 433,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 434,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 435,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 436,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 437,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 438,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 439,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 440,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 441,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 442,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 443,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 444,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 445,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 446,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 447,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 448,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 449,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 450,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 451,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 452,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 453,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 454,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 455,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 456,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 457,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 458,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 459,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 460,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 461,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 462,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 463,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 464,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 465,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 466,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 467,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 468,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 469,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 470,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 471,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 472,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 473,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 474,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 475,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 476,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 477,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 478,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 479,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 480,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 481,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 482,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 483,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 484,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 485,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 486,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 487,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 488,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 489,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 490,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 491,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 492,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 493,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 494,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 495,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 496,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 497,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 498,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 499,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 500,
                column: "estado",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pomodoros",
                keyColumn: "id_pomodoro",
                keyValue: 501,
                column: "estado",
                value: true);
        }
    }
}
