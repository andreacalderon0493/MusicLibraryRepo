using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MusicLibraryAPI.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: false),
                    Artist = table.Column<string>(type: "longtext", nullable: false),
                    Album = table.Column<string>(type: "longtext", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Genre = table.Column<string>(type: "longtext", nullable: false),
                    Like = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Album", "Artist", "Genre", "Like", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "Un Verano Sin ti", "Bad Bunny", "Reggaeton", 0, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Callaita" },
                    { 2, "Un Verano Sin ti", "Bad Bunny", "Reggeaton", 0, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moscow Mule" },
                    { 3, "Un Verano Sin ti", "Bad Bunny", "Reggeaton", 0, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Titi Me Pregunto" },
                    { 4, "Un Verano Sin ti", "Bad Bunny", "Reggeaton", 0, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Después de la Playa" },
                    { 5, "Un Verano Sin ti", "Bad Bunny", "Reggeaton", 0, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Me Porto Bonito" },
                    { 6, "Un Verano Sin ti", "Bad Bunny", "Reggeaton", 0, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Party" },
                    { 7, "Un Verano Sin ti", "Bad Bunny", "Reggeaton", 0, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neverita" },
                    { 8, "Un Verano Sin ti", "Bad Bunny", "Reggeaton", 0, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "El Apagón" },
                    { 9, "Un Verano Sin ti", "Bad Bunny", "Reggeaton", 0, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrea" },
                    { 10, "Un Verano Sin ti", "Bad Bunny", "Reggeaton", 0, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Me Fui de Vacaciones" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");
        }
    }
}
