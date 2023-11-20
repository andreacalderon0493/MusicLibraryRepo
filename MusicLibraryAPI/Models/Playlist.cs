using System;
using System.ComponentModel.DataAnnotations;

namespace MusicLibraryAPI.Models
{
	public class Playlist
	{
        [Key]
        public int Id { get; set; }
		public string Name { get; set; }

		//Navigation property for the one-to-many relationships
		public List<Song> songs { get; set; }
	}
   
}

