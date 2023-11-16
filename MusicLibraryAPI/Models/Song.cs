﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MusicLibraryAPI.Models
{
	public class Song
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Artist { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public int Like { get; set; }

        public Song()
		{
           
		}
	}
}

