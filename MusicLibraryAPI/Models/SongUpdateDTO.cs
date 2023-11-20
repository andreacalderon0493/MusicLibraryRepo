using System;
namespace MusicLibraryAPI.Models
{
	public class SongUpdateDTO
	{
		public string? Title { get; set; }
		public string? Artist { get; set; }
        public string? Album { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public int? Like { get; set; }
    }
}

