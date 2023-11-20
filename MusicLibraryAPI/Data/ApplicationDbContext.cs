using System;
using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;
using MusicLibraryAPI.Models;

namespace MusicLibraryAPI.Data
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Song> Songs { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
		public ApplicationDbContext(DbContextOptions options) : base(options)
		{
		}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Configure the Song entity

            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    Id = 1,
                    Title = "Callaita",
                    Artist = "Bad Bunny",
                    Album = "Un Verano Sin ti",
                    ReleaseDate = new DateTime(2019, 05, 31),
                    Genre = "Reggaeton"
                },
                new Song
                {
                    Id = 2,
                    Title = "Moscow Mule",
                    Artist = "Bad Bunny",
                    Album = "Un Verano Sin ti",
                    ReleaseDate = new DateTime(2019, 05, 31),
                    Genre = "Reggeaton"
                },
                new Song
                {
                    Id = 3,
                    Title = "Titi Me Pregunto",
                    Artist = "Bad Bunny",
                    Album = "Un Verano Sin ti",
                    ReleaseDate = new DateTime(2019, 05, 31),
                    Genre = "Reggeaton"
                },
                new Song
                {
                    Id = 4,
                    Title = "Después de la Playa",
                    Artist = "Bad Bunny",
                    Album = "Un Verano Sin ti",
                    ReleaseDate = new DateTime(2019, 05, 31),
                    Genre = "Reggeaton"

                },
                new Song
                {
                    Id = 5,
                    Title = "Me Porto Bonito",
                    Artist = "Bad Bunny",
                    Album = "Un Verano Sin ti",
                    ReleaseDate = new DateTime(2019, 05, 31),
                    Genre = "Reggeaton"

                },
                 new Song
                 {
                     Id = 6,
                     Title = "Party",
                     Artist = "Bad Bunny",
                     Album = "Un Verano Sin ti",
                     ReleaseDate = new DateTime(2019, 05, 31),
                     Genre = "Reggeaton"

                 },
                  new Song
                  {
                      Id = 7,
                      Title = "Neverita",
                      Artist = "Bad Bunny",
                      Album = "Un Verano Sin ti",
                      ReleaseDate = new DateTime(2019, 05, 31),
                      Genre = "Reggeaton"

                  },
                   new Song
                   {
                       Id = 8,
                       Title = "El Apagón",
                       Artist = "Bad Bunny",
                       Album = "Un Verano Sin ti",
                       ReleaseDate = new DateTime(2019, 05, 31),
                       Genre = "Reggeaton"

                   },
                   new Song
                   {
                       Id = 9,
                       Title = "Andrea",
                       Artist = "Bad Bunny",
                       Album = "Un Verano Sin ti",
                       ReleaseDate = new DateTime(2019, 05, 31),
                       Genre = "Reggeaton"

                   },
                   new Song
                   {
                       Id = 10,
                       Title = "Me Fui de Vacaciones",
                       Artist = "Bad Bunny",
                       Album = "Un Verano Sin ti",
                       ReleaseDate = new DateTime(2019, 05, 31),
                       Genre = "Reggeaton"

                   }
                   );

                   modelBuilder.Entity<Playlist>().HasData(
                   new Playlist
                   {
                       Id = 1,
                       Name = "Favorite Songs"
                   },
                   new Playlist
                   {
                       Id = 2,
                       Name = "Dancing Music"

                   }
                );
        }
    }
}

