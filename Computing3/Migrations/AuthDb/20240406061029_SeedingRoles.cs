using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Computing3.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class SeedingRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3edf110e-6125-4e26-adaf-2ead500eaf62", "1", "Admin", "Admin" },
                    { "7fbd83d3-e0e1-4b47-a5c2-c48040cf531f", "2", "User", "User" },
                    { "cd03b454-6491-4342-a19a-220a3070fcbf", "3", "HR", "HR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3edf110e-6125-4e26-adaf-2ead500eaf62");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fbd83d3-e0e1-4b47-a5c2-c48040cf531f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd03b454-6491-4342-a19a-220a3070fcbf");
        }
    }
}
