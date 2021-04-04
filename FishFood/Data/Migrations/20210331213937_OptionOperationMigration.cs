using Microsoft.EntityFrameworkCore.Migrations;

namespace FishFood.Data.Migrations
{
    public partial class OptionOperationMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Option_GameText_GameTextId",
                table: "Option");

            migrationBuilder.DropIndex(
                name: "IX_Option_GameTextId",
                table: "Option");

            migrationBuilder.DropColumn(
                name: "GameTextId",
                table: "Option");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GameTextId",
                table: "Option",
                type: "int",
                nullable: true);

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
                onDelete: ReferentialAction.Restrict);
        }
    }
}
