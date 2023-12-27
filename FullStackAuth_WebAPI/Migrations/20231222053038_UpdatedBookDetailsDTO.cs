using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullStackAuth_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedBookDetailsDTO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0568c46d-bc99-4492-87ae-706a7bad938b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7b7b675-c1ae-4f04-8dec-1022d648b812");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "73dc52b7-f899-4941-849f-53e293f84a2b", null, "Admin", "ADMIN" },
                    { "f16ab238-7253-436a-bd71-0a43806a5d9a", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73dc52b7-f899-4941-849f-53e293f84a2b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f16ab238-7253-436a-bd71-0a43806a5d9a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0568c46d-bc99-4492-87ae-706a7bad938b", null, "User", "USER" },
                    { "d7b7b675-c1ae-4f04-8dec-1022d648b812", null, "Admin", "ADMIN" }
                });
        }
    }
}
