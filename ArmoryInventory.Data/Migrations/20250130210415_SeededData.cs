using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArmoryInventory.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeededData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CheckedOut", "Defects", "HasAllComponents", "ItemType", "MissingComponents", "MissionCapable", "SerialNumber" },
                values: new object[,]
                {
                    { new Guid("05eb7f71-cc56-48c9-b886-2d3a9352057c"), 2, "[]", 2, 1, "[\"Missing 2 stakes\",\"Missing one blue pole\"]", 2, "355N3" },
                    { new Guid("24caa1b3-9433-4883-ad2a-ced8ee8443ef"), 1, "[\"Back connectors bent\",\"Front Light does\\u0027nt work\"]", 1, 2, "[]", 1, "367N2" },
                    { new Guid("3c3db93c-ba89-4ec7-87b5-02d377bfa7b1"), 1, "[\"Mic key does not work\"]", 1, 3, "[]", 1, "623N5" },
                    { new Guid("465efd68-c55d-4f49-96f0-1c7e0228c805"), 2, "[]", 1, 1, "[\"Missing 1 stake\",\"Missing 2 blue pole\",\"Missing Hammer\"]", 1, "272N8" },
                    { new Guid("53d080d3-6ebc-4b97-abd4-e0e3daebbd26"), 2, "[]", 1, 1, "[\"Missing 2 stakes\",\"Missing one blue pole\"]", 1, "865N3" },
                    { new Guid("54b85a9f-7b8d-4aed-ad46-28efdf0d85b4"), 1, "[\"Back connectors bent\",\"Front Light does\\u0027nt work\"]", 1, 2, "[]", 1, "372F4" },
                    { new Guid("672dc07c-16e2-4871-b5ce-8c590c816f0a"), 1, "[\"Back connectors bent\",\"Front Light does\\u0027nt work\"]", 1, 2, "[]", 1, "233N7" },
                    { new Guid("84af1935-628b-4203-b782-d9e9a56554d9"), 2, "[\"Mic key does not work\"]", 1, 3, "[]", 1, "363S2" },
                    { new Guid("8589c1b6-86d2-4202-92c9-688370f7a3b0"), 2, "[]", 1, 1, "[\"Missing 1 stake\",\"Missing 2 blue pole\",\"Missing Hammer\"]", 1, "624N2" },
                    { new Guid("94368184-0101-4e9f-b9de-a8f3900d415a"), 1, "[\"Mic key does not work\"]", 1, 3, "[]", 1, "124N8" },
                    { new Guid("9497ad4e-6814-4350-93db-d7ad6b700562"), 2, "[]", 1, 1, "[\"Missing 1 stake\",\"Missing 2 blue pole\",\"Missing Hammer\"]", 1, "557N2" },
                    { new Guid("98ce6fb5-9ab6-4466-b1da-2d9d2568e1a3"), 2, "[]", 1, 1, "[\"Missing 1 stake\",\"Missing 2 blue pole\",\"Missing Hammer\"]", 1, "442F4" },
                    { new Guid("a1ca67d1-265e-473c-8087-e33660de8cae"), 2, "[]", 1, 5, "[\"Missing 1 stake\",\"Missing 2 blue pole\",\"Missing Hammer\"]", 1, "637N2" },
                    { new Guid("c7a072e9-9175-4403-8c64-be4bb8d7bb3b"), 2, "[]", 1, 1, "[\"Missing 2 stakes\",\"Missing one blue pole\"]", 1, "522F4" },
                    { new Guid("c7bb57a3-f967-47f8-a4a4-d4529e898c25"), 2, "[\"Back connectors bent\",\"Front Light doesn\\u0027t work\"]", 1, 2, "[]", 1, "111N5" },
                    { new Guid("cc97f041-7bfb-4d12-af53-7bcd8ae2b7a2"), 2, "[\"Mic key does not work\"]", 1, 3, "[]", 1, "523F5" },
                    { new Guid("d3465f1a-3e4b-4a85-9cde-8fdc156885ac"), 2, "[\"Back connectors bent\",\"Front Light does\\u0027nt work\"]", 1, 2, "[]", 1, "867N2" },
                    { new Guid("d441a0db-dfc7-460f-bfc5-44136dbc6a03"), 2, "[\"Mic key does not work\"]", 2, 3, "[]", 2, "342N7" },
                    { new Guid("d507734c-1d27-438c-8cf9-7560e1aa329c"), 2, "[]", 1, 1, "[\"Missing 2 stakes\",\"Missing one blue pole\"]", 1, "222NF" },
                    { new Guid("e30f58ff-46eb-452d-827c-f7af3f5a74db"), 2, "[]", 1, 1, "[\"Missing 2 stakes\",\"Missing one blue pole\"]", 1, "522N4" },
                    { new Guid("fb9540a3-33b8-4d0a-8d06-6ff3946befd6"), 2, "[\"Mic key does not work\"]", 1, 3, "[]", 1, "467N9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("05eb7f71-cc56-48c9-b886-2d3a9352057c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("24caa1b3-9433-4883-ad2a-ced8ee8443ef"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3c3db93c-ba89-4ec7-87b5-02d377bfa7b1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("465efd68-c55d-4f49-96f0-1c7e0228c805"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("53d080d3-6ebc-4b97-abd4-e0e3daebbd26"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("54b85a9f-7b8d-4aed-ad46-28efdf0d85b4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("672dc07c-16e2-4871-b5ce-8c590c816f0a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("84af1935-628b-4203-b782-d9e9a56554d9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8589c1b6-86d2-4202-92c9-688370f7a3b0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("94368184-0101-4e9f-b9de-a8f3900d415a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9497ad4e-6814-4350-93db-d7ad6b700562"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("98ce6fb5-9ab6-4466-b1da-2d9d2568e1a3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a1ca67d1-265e-473c-8087-e33660de8cae"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c7a072e9-9175-4403-8c64-be4bb8d7bb3b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c7bb57a3-f967-47f8-a4a4-d4529e898c25"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("cc97f041-7bfb-4d12-af53-7bcd8ae2b7a2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d3465f1a-3e4b-4a85-9cde-8fdc156885ac"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d441a0db-dfc7-460f-bfc5-44136dbc6a03"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d507734c-1d27-438c-8cf9-7560e1aa329c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e30f58ff-46eb-452d-827c-f7af3f5a74db"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fb9540a3-33b8-4d0a-8d06-6ff3946befd6"));
        }
    }
}
