using Microsoft.EntityFrameworkCore.Migrations;

namespace FishFood.Data.Migrations
{
    public partial class LinkIdAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LinkId",
                table: "Option",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "GameText",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LinkId",
                table: "Option");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "GameText");
        }
    }
}
