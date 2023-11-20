using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicLibraryAPI.Data;
using MusicLibraryAPI.Models;
using NuGet.Protocol.Core.Types;

namespace MusicLibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public SongsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/Songs
        [HttpGet]
        public IActionResult Get()
        {
            var songs = _context.Songs.ToList();
            return Ok(songs);
        }

        // GET: api/Songs/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var song = _context.Songs.Find(id);
            if (song == null)
            {
                return NotFound();
            }
            return Ok(song);
        }

        // POST: api/Songs
        [HttpPost]
        public IActionResult Post([FromBody] Song song)
        {
            _context.Songs.Add(song);
            _context.SaveChanges();
            return StatusCode(201, song);
        }

        // PUT: api/Songs/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Song song)
        {
            var updatedSong = _context.Songs.Find(id);
          
            if (updatedSong == null)
            {
                return NotFound();
            }
            else
            {
                updatedSong.Title = song.Title;
                updatedSong.Artist = song.Artist;
                updatedSong.Album = song.Album;
                updatedSong.ReleaseDate = song.ReleaseDate;
                updatedSong.Genre = song.Genre;
                _context.Songs.Update(updatedSong);
                _context.SaveChanges();
                return Ok(updatedSong);
            }

            //var otherVersionSong = _context.Songs.Where(s => s.Id == id).FirstOrDefault();

        }

        // DELETE: api/Songs/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var song = _context.Songs.Find(id);
            if (song == null)
            {
                return NotFound();
            }
            _context.Songs.Remove(song);
            _context.SaveChanges();
            return NoContent();
        }
        [HttpPatch("Like/{id}")]
        public IActionResult LikeSong(int id)
        {
            var song = _context.Songs.Find(id);

            if (song == null)
            {
                return NotFound();
            }
            else
            {
                // Increment the likes and save to the database
                song.Like++;
                _context.Songs.Update(song);
                _context.SaveChanges();
                return Ok(song);
            }
        }
        [HttpPatch("{id}")]
        public IActionResult UpdateSong(int id, [FromBody] SongUpdateDTO songUpdateDTO)
        {
            var song = _context.Songs.Find(id);

            if (song == null)
            {
                return NotFound();
            }

            // Update only the properties that are provided in the DTO
            if (songUpdateDTO.Title != null)
            {
                song.Title = songUpdateDTO.Title;
            }

            if (songUpdateDTO.Artist != null)
            {
                song.Artist = songUpdateDTO.Artist;
            }
            if (songUpdateDTO.Genre != null)
            {
                song.Genre = songUpdateDTO.Genre;
            }
            if (songUpdateDTO.ReleaseDate != null)
            {
                song.ReleaseDate = (DateTime)songUpdateDTO.ReleaseDate;
            }
            if (songUpdateDTO.Album != null)
            {
                song.Album = songUpdateDTO.Album;
            }
            if (songUpdateDTO.Like != null)
            {
                song.Like = (int)songUpdateDTO.Like;
            }
            // Update any other properties here...

            _context.Songs.Update(song);
            _context.SaveChanges();

            return Ok(song);
        }
        // SongsController.cs
        [HttpPost("add-to-playlist/{playlistId}")]
        public IActionResult AddSongToPlaylist(int playlistId, [FromBody] Song song)
        {
            var playlist = _context.Playlists.Find(playlistId);

            if (playlist == null)
            {
                return NotFound("Playlist not found.");
            }

            song.PlaylistId = playlistId;
            _context.Songs.Add(song);

            return Ok("Song added to playlist successfully.");
        }


    }
}
