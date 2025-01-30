using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArmoryInventory.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    SerialNumber = table.Column<string>(type: "TEXT", nullable: true),
                    ItemType = table.Column<int>(type: "INTEGER", nullable: false),
                    HasAllComponents = table.Column<int>(type: "INTEGER", nullable: false),
                    MissionCapable = table.Column<int>(type: "INTEGER", nullable: false),
                    CheckedOut = table.Column<int>(type: "INTEGER", nullable: false),
                    Defects = table.Column<string>(type: "TEXT", nullable: true),
                    MissingComponents = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Checkouts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ItemId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DateCheckedOut = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateCheckedIn = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CheckedOutTo = table.Column<string>(type: "TEXT", nullable: false),
                    DefectsBefore = table.Column<string>(type: "TEXT", nullable: false),
                    DefectsAfter = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Checkouts_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_ItemId",
                table: "Checkouts",
                column: "ItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Checkouts");

            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
