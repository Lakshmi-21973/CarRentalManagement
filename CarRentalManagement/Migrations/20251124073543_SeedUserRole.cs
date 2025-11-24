using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "248817f4-e0eb-4e82-aef0-31a960673998", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEABT2vkosZ7IoOHZDBTIauaxay8euNA+f8uSkxUwYRY4A51S49OSsZWDZnWXaLLrhg==", null, false, "99289c9c-85a1-4ec6-abf1-28a2ad90ab68", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 35, 43, 154, DateTimeKind.Local).AddTicks(3426), new DateTime(2025, 11, 24, 15, 35, 43, 154, DateTimeKind.Local).AddTicks(3441) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 35, 43, 154, DateTimeKind.Local).AddTicks(3444), new DateTime(2025, 11, 24, 15, 35, 43, 154, DateTimeKind.Local).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 35, 43, 154, DateTimeKind.Local).AddTicks(3713), new DateTime(2025, 11, 24, 15, 35, 43, 154, DateTimeKind.Local).AddTicks(3714) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 35, 43, 154, DateTimeKind.Local).AddTicks(3715), new DateTime(2025, 11, 24, 15, 35, 43, 154, DateTimeKind.Local).AddTicks(3716) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 35, 43, 154, DateTimeKind.Local).AddTicks(3833), new DateTime(2025, 11, 24, 15, 35, 43, 154, DateTimeKind.Local).AddTicks(3834) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 35, 43, 154, DateTimeKind.Local).AddTicks(3837), new DateTime(2025, 11, 24, 15, 35, 43, 154, DateTimeKind.Local).AddTicks(3837) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 35, 43, 154, DateTimeKind.Local).AddTicks(3839), new DateTime(2025, 11, 24, 15, 35, 43, 154, DateTimeKind.Local).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 35, 43, 154, DateTimeKind.Local).AddTicks(3841), new DateTime(2025, 11, 24, 15, 35, 43, 154, DateTimeKind.Local).AddTicks(3842) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 21, 28, 899, DateTimeKind.Local).AddTicks(7975), new DateTime(2025, 11, 24, 15, 21, 28, 899, DateTimeKind.Local).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 21, 28, 899, DateTimeKind.Local).AddTicks(7990), new DateTime(2025, 11, 24, 15, 21, 28, 899, DateTimeKind.Local).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 21, 28, 899, DateTimeKind.Local).AddTicks(8154), new DateTime(2025, 11, 24, 15, 21, 28, 899, DateTimeKind.Local).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 21, 28, 899, DateTimeKind.Local).AddTicks(8156), new DateTime(2025, 11, 24, 15, 21, 28, 899, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 21, 28, 899, DateTimeKind.Local).AddTicks(8217), new DateTime(2025, 11, 24, 15, 21, 28, 899, DateTimeKind.Local).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 21, 28, 899, DateTimeKind.Local).AddTicks(8219), new DateTime(2025, 11, 24, 15, 21, 28, 899, DateTimeKind.Local).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 21, 28, 899, DateTimeKind.Local).AddTicks(8221), new DateTime(2025, 11, 24, 15, 21, 28, 899, DateTimeKind.Local).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 21, 28, 899, DateTimeKind.Local).AddTicks(8222), new DateTime(2025, 11, 24, 15, 21, 28, 899, DateTimeKind.Local).AddTicks(8222) });
        }
    }
}
