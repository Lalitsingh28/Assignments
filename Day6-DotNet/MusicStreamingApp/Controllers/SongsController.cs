using Microsoft.AspNetCore.Mvc;
using MusicStreamingApp.Context;
using MusicStreamingApp.Models;
using Org.BouncyCastle.Utilities;

namespace MusicStreamingApp.Controllers
{
    [ApiController]
    [Route("song/")]
    public class SongsController : ControllerBase
    {
        private MusicContext _musicContext;

        [HttpGet]
        public IActionResult GetAllSongs([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            if (page <= 0 || pageSize <= 0)
            {
                return BadRequest("Invalid page or pageSize values");
            }

            var paginatedSongs = _musicContext.Songs.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            return Ok(paginatedSongs);
        }

        [HttpGet("{id}")]
        public IActionResult GetSong(int id)
        {
            try
            {
                var song = _musicContext.Songs.FirstOrDefault(s => s.Id == id);
                if (song == null)
                {
                    return NotFound("Song not found");
                }

                return Ok(song);
            }
            catch (Exception ex)
            { 
                return StatusCode(500, "An error occurred");
            }
        }
    }
}
