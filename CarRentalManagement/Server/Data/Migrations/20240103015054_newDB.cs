using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class newDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "RentalRate",
                table: "Vehicles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RentalRate",
                table: "Vehicles");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c589a4a-674b-49a0-92b3-3959482efeec", "AQAAAAIAAYagAAAAEDWhPhLzFSi349xvAyWDV0yZl4lrlPyNIrA7BUoqgjfdzflVUGJzo8YJboliNo9f7Q==", "b427f9f0-a2e9-4153-8bc1-d647ffd91e6d" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 20, 44, 0, 581, DateTimeKind.Local).AddTicks(2287), new DateTime(2023, 11, 9, 20, 44, 0, 581, DateTimeKind.Local).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 20, 44, 0, 581, DateTimeKind.Local).AddTicks(2303), new DateTime(2023, 11, 9, 20, 44, 0, 581, DateTimeKind.Local).AddTicks(2303) });
        }
    }
}
