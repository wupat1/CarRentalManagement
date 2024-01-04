using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class customerupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b1ac1ed-73a0-404a-990f-35d6e0d55446", "AQAAAAIAAYagAAAAEKGrOyC3IW6riaGCWQ3J+vuXjt+mdboSOmkgFxg18zO2+5WWTdJEnSkjrvYzclbDAw==", "30267091-7652-4f66-ba91-fbd3138abc83" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 10, 41, 15, 777, DateTimeKind.Local).AddTicks(3879), new DateTime(2024, 1, 3, 10, 41, 15, 777, DateTimeKind.Local).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 10, 41, 15, 777, DateTimeKind.Local).AddTicks(3892), new DateTime(2024, 1, 3, 10, 41, 15, 777, DateTimeKind.Local).AddTicks(3892) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d967c31-9337-4117-b03f-1d8b1578b1d1", "AQAAAAIAAYagAAAAEKVK8iiJmS/qHmnivK/gI/ZWXnjRAdEEYzW8v9e9Up3iJwhNA3QnfYJ0KEHEd2A/Ww==", "e48f3bf4-bc1b-4bcb-9694-7d2adbbc923a" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 9, 50, 54, 463, DateTimeKind.Local).AddTicks(8875), new DateTime(2024, 1, 3, 9, 50, 54, 463, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 9, 50, 54, 463, DateTimeKind.Local).AddTicks(8894), new DateTime(2024, 1, 3, 9, 50, 54, 463, DateTimeKind.Local).AddTicks(8894) });
        }
    }
}
