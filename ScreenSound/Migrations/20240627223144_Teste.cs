using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class Teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlbumId",
                table: "BandaAvaliacao",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BandaAvaliacao_AlbumId",
                table: "BandaAvaliacao",
                column: "AlbumId");

            migrationBuilder.AddForeignKey(
                name: "FK_BandaAvaliacao_Album_AlbumId",
                table: "BandaAvaliacao",
                column: "AlbumId",
                principalTable: "Album",
                principalColumn: "AlbumId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BandaAvaliacao_Album_AlbumId",
                table: "BandaAvaliacao");

            migrationBuilder.DropIndex(
                name: "IX_BandaAvaliacao_AlbumId",
                table: "BandaAvaliacao");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "BandaAvaliacao");
        }
    }
}
