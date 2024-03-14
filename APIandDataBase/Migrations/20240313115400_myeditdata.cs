using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APIandDataBase.Migrations
{
    /// <inheritdoc />
    public partial class myeditdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6ad69e70-67bc-4a61-9462-7cf0756c51c7", "2", "Admin", "Admin" },
                    { "ecee379e-e66d-4e18-86c7-5d43f3b4cb6f", "3", "User", "User" },
                    { "fb2c09e4-f33d-434d-9289-d2e853ba1a2d", "1", "Superadmin", "Superadmin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "ba8bcefd-4ca4-4e32-a8fd-f8a0c0a3d59a", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", null, null, false, "cc629bbd-db53-434b-9687-0101feeff195", false, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ad69e70-67bc-4a61-9462-7cf0756c51c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecee379e-e66d-4e18-86c7-5d43f3b4cb6f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb2c09e4-f33d-434d-9289-d2e853ba1a2d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");
        }
    }
}
