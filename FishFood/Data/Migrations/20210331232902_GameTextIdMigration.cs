using Microsoft.EntityFrameworkCore.Migrations;

namespace FishFood.Data.Migrations
{
    public partial class GameTextIdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PassageId",
                table: "Option",
                newName: "GameTextId");

            migrationBuilder.CreateIndex(
                name: "IX_Option_GameTextId",
                table: "Option",
                column: "GameTextId");

            migrationBuilder.AddForeignKey(
                name: "FK_Option_GameText_GameTextId",
                table: "Option",
                column: "GameTextId",
                principalTable: "GameText",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Option_GameText_GameTextId",
                table: "Option");

            migrationBuilder.DropIndex(
                name: "IX_Option_GameTextId",
                table: "Option");

            migrationBuilder.RenameColumn(
                name: "GameTextId",
                table: "Option",
                newName: "PassageId");
        }
    }
}
