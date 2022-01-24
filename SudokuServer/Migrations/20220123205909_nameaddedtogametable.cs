using Microsoft.EntityFrameworkCore.Migrations;

namespace SudokuServer.Migrations
{
    public partial class nameaddedtogametable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Users_userId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_userId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Games");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "name",
                table: "Games");

            migrationBuilder.AddColumn<int>(
                name: "userId",
                table: "Games",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Games_userId",
                table: "Games",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Users_userId",
                table: "Games",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
