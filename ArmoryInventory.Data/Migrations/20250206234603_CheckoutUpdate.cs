using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArmoryInventory.Data.Migrations
{
    /// <inheritdoc />
    public partial class CheckoutUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCheckedIn", "DateCheckedOut" },
                values: new object[] { null, new DateOnly(2019, 5, 9) });

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCheckedIn", "DateCheckedOut" },
                values: new object[] { null, new DateOnly(2020, 5, 9) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCheckedIn", "DateCheckedOut" },
                values: new object[] { null, new DateTime(2019, 5, 9, 9, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCheckedIn", "DateCheckedOut" },
                values: new object[] { null, new DateTime(2020, 5, 9, 9, 15, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
