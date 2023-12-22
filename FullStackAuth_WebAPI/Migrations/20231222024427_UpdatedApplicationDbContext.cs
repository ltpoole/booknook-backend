using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullStackAuth_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedApplicationDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "458d8456-b2e0-490f-ab3a-f4d71990e30d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1515aba-839d-4d02-91d5-de89d886c1f1");

            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "Reviews",
                type: "double",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0568c46d-bc99-4492-87ae-706a7bad938b", null, "User", "USER" },
                    { "d7b7b675-c1ae-4f04-8dec-1022d648b812", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0568c46d-bc99-4492-87ae-706a7bad938b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7b7b675-c1ae-4f04-8dec-1022d648b812");

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Reviews",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "458d8456-b2e0-490f-ab3a-f4d71990e30d", null, "Admin", "ADMIN" },
                    { "a1515aba-839d-4d02-91d5-de89d886c1f1", null, "User", "USER" }
                });
        }
    }
}
