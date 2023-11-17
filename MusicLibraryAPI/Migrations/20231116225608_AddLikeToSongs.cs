using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicLibraryAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddLikeToSongs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Like",
                table: "Songs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Like",
                table: "Songs");
        }
    }
}
