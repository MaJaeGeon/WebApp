using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace webapp.backend.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Forecasts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    TemperatureC = table.Column<int>(type: "integer", nullable: false),
                    Summary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forecasts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Forecasts",
                columns: new[] { "Id", "Date", "Summary", "TemperatureC" },
                values: new object[,]
                {
                    { 1, new DateOnly(2024, 2, 4), "Mild", 32 },
                    { 2, new DateOnly(2024, 2, 5), "Bracing", 4 },
                    { 3, new DateOnly(2024, 2, 6), "Chilly", 42 },
                    { 4, new DateOnly(2024, 2, 7), "Sweltering", 7 },
                    { 5, new DateOnly(2024, 2, 8), "Warm", -6 },
                    { 6, new DateOnly(2024, 2, 9), "Chilly", 39 },
                    { 7, new DateOnly(2024, 2, 10), "Freezing", 7 },
                    { 8, new DateOnly(2024, 2, 11), "Balmy", 39 },
                    { 9, new DateOnly(2024, 2, 12), "Hot", -20 },
                    { 10, new DateOnly(2024, 2, 13), "Freezing", 19 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Forecasts");
        }
    }
}
