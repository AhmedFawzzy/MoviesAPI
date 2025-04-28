using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesAPI.Migrations
{
    public partial class updatename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_moviess_genres_GenreId",
                table: "moviess");

            migrationBuilder.DropPrimaryKey(
                name: "PK_moviess",
                table: "moviess");

            migrationBuilder.RenameTable(
                name: "moviess",
                newName: "movies");

            migrationBuilder.RenameIndex(
                name: "IX_moviess_GenreId",
                table: "movies",
                newName: "IX_movies_GenreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_movies",
                table: "movies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_movies_genres_GenreId",
                table: "movies",
                column: "GenreId",
                principalTable: "genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movies_genres_GenreId",
                table: "movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_movies",
                table: "movies");

            migrationBuilder.RenameTable(
                name: "movies",
                newName: "moviess");

            migrationBuilder.RenameIndex(
                name: "IX_movies_GenreId",
                table: "moviess",
                newName: "IX_moviess_GenreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_moviess",
                table: "moviess",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_moviess_genres_GenreId",
                table: "moviess",
                column: "GenreId",
                principalTable: "genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
