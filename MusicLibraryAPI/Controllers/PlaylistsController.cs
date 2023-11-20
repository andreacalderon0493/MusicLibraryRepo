using System;
using Microsoft.AspNetCore.Mvc;
using MusicLibraryAPI.Data;
using MusicLibraryAPI.Models;

namespace MusicLibraryAPI.Controllers
{
	[Route("api/playlists")]
	public class PlaylistsController : ControllerBase
	{
        private readonly ApplicationDbContext _context;

        public PlaylistsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/Playlists
        [HttpGet]
        public IActionResult Get()
        {
            var playlists = _context.Playlists.ToList();
            return Ok(playlists);
        }

        // GET: api/Playlists/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var playlists = _context.Playlists.Find(id);
            if (playlists == null)
            {
                return NotFound();
            }
            return Ok(playlists);
        }

        // POST: api/Playlists
        [HttpPost]
        public IActionResult Post([FromBody] Playlist playlist)
        {
            _context.Playlists.Add(playlist);
            _context.SaveChanges();
            return StatusCode(201, playlist);
        }

        // PUT: api/Playlists/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Playlist playlist)
        {
            var updatedPlaylist = _context.Playlists.Find(id);

            if (updatedPlaylist == null)
            {
                return NotFound();
            }
            else
            {
                updatedPlaylist.Name= playlist.Name;
                _context.Playlists.Update(updatedPlaylist);
                _context.SaveChanges();
                return Ok(updatedPlaylist);
            }

            //var otherVersionSong = _context.Songs.Where(s => s.Id == id).FirstOrDefault();

        }

        // DELETE: api/Playlists/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var playlist = _context.Playlists.Find(id);
            if (playlist == null)
            {
                return NotFound();
            }
            _context.Playlists.Remove(playlist);
            _context.SaveChanges();
            return NoContent();
        }
    }
}

