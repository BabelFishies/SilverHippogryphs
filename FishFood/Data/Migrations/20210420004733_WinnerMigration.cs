using Microsoft.EntityFrameworkCore.Migrations;

namespace FishFood.Data.Migrations
{
    public partial class WinnerMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsALoser",
                table: "GameText",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAWinner",
                table: "GameText",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsALoser",
                table: "GameText");

            migrationBuilder.DropColumn(
                name: "IsAWinner",
                table: "GameText");
        }
    }
}
