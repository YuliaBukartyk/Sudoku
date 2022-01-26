using Microsoft.EntityFrameworkCore.Migrations;

namespace SudokuServer.Migrations
{
    public partial class propresultaddedtogames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "result",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "result",
                table: "Games");
        }
    }
}
