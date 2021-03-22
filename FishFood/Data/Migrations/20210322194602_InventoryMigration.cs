using Microsoft.EntityFrameworkCore.Migrations;

namespace FishFood.Data.Migrations
{
    public partial class InventoryMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CharacterPortrait",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImgSrc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterPortrait", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameInventory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameInventory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InventoryItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasItem = table.Column<bool>(type: "bit", nullable: false),
                    GameInventoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryItem_GameInventory_GameInventoryId",
                        column: x => x.GameInventoryId,
                        principalTable: "GameInventory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InventoryItem_GameInventoryId",
                table: "InventoryItem",
                column: "GameInventoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterPortrait");

            migrationBuilder.DropTable(
                name: "InventoryItem");

            migrationBuilder.DropTable(
                name: "GameInventory");
        }
    }
}
