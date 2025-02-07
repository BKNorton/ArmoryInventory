using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArmoryInventory.Data.Migrations
{
    /// <inheritdoc />
    public partial class MoreCheckoutDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Checkouts",
                columns: new[] { "Id", "CheckedOutTo", "DateCheckedIn", "DateCheckedOut", "DefectsAfter", "DefectsBefore", "ItemId" },
                values: new object[,]
                {
                    { 3, "Alpha Battery", null, new DateOnly(2018, 7, 20), "[]", "[]", new Guid("05eb7f71-cc56-48c9-b886-2d3a9352057c") },
                    { 4, "Alpha Battery", null, new DateOnly(2018, 10, 12), "[]", "[]", new Guid("05eb7f71-cc56-48c9-b886-2d3a9352057c") },
                    { 5, "Charlie Battery", null, new DateOnly(2019, 7, 20), "[]", "[]", new Guid("05eb7f71-cc56-48c9-b886-2d3a9352057c") },
                    { 6, "Alpha Battery", null, new DateOnly(2019, 5, 10), "[]", "[]", new Guid("05eb7f71-cc56-48c9-b886-2d3a9352057c") },
                    { 7, "Alpha Battery", null, new DateOnly(2019, 2, 5), "[]", "[]", new Guid("05eb7f71-cc56-48c9-b886-2d3a9352057c") },
                    { 8, "First Sergeant", null, new DateOnly(2020, 7, 20), "[]", "[]", new Guid("05eb7f71-cc56-48c9-b886-2d3a9352057c") },
                    { 9, "TOC", null, new DateOnly(2021, 7, 20), "[]", "[]", new Guid("05eb7f71-cc56-48c9-b886-2d3a9352057c") },
                    { 10, "Bravo Battery", null, new DateOnly(2022, 7, 20), "[]", "[]", new Guid("05eb7f71-cc56-48c9-b886-2d3a9352057c") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
