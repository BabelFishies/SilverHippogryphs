using Microsoft.EntityFrameworkCore.Migrations;

namespace FishFood.Data.Migrations
{
    public partial class OptionMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_gameText",
                table: "gameText");

            migrationBuilder.RenameTable(
                name: "gameText",
                newName: "GameText");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameText",
                table: "GameText",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Option",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PassageId = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameTextId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Option", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Option_GameText_GameTextId",
                        column: x => x.GameTextId,
                        principalTable: "GameText",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Option_GameTextId",
                table: "Option",
                column: "GameTextId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Option");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameText",
                table: "GameText");

            migrationBuilder.RenameTable(
                name: "GameText",
                newName: "gameText");

            migrationBuilder.AddPrimaryKey(
                name: "PK_gameText",
                table: "gameText",
                column: "Id");
        }
    }
}
