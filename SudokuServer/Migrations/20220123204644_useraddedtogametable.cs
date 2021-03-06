using Microsoft.EntityFrameworkCore.Migrations;

namespace SudokuServer.Migrations
{
    public partial class useraddedtogametable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "verificationPassword",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Users_userId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_userId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "verificationPassword",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Games");
        }
    }
}
