using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicLibraryAPI.Models
{
	public class Song
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public int Like { get; set; }

        //Foreign
        [ForeignKey("Playlist")]
        public int PlaylistId { get; set; }
        //Navigation prop for the one-to-many relationship
        public Playlist playlist { get; set; }
    }
    
}

