using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrezyWeather.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Weather",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Temperature = table.Column<float>(type: "real", nullable: false),
                    Humidity = table.Column<float>(type: "real", nullable: false),
                    AirQuality = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weather", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Weather",
                columns: new[] { "ID", "AirQuality", "Humidity", "Temperature", "Time" },
                values: new object[] { 1, "Fair", 78f, 28f, new DateTime(2022, 11, 13, 15, 48, 9, 622, DateTimeKind.Local).AddTicks(6580) });

            migrationBuilder.InsertData(
                table: "Weather",
                columns: new[] { "ID", "AirQuality", "Humidity", "Temperature", "Time" },
                values: new object[] { 2, "Healthy", 84f, 27f, new DateTime(2022, 11, 13, 14, 48, 9, 622, DateTimeKind.Local).AddTicks(6610) });

            migrationBuilder.InsertData(
                table: "Weather",
                columns: new[] { "ID", "AirQuality", "Humidity", "Temperature", "Time" },
                values: new object[] { 3, "Healthy", 40f, 33f, new DateTime(2022, 11, 13, 13, 48, 9, 622, DateTimeKind.Local).AddTicks(6610) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weather");
        }
    }
}
