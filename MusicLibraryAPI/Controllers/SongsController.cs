using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicLibraryAPI.Data;
using MusicLibraryAPI.Models;

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
    }
}
