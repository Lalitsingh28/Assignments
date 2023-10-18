using Microsoft.AspNetCore.Mvc;
using MusicStreamingApp.Context;
using MusicStreamingApp.Models;
using Org.BouncyCastle.Utilities;

namespace MusicStreamingApp.Controllers
{
    [ApiController]
    [Route("playlist/")]
    public class PlaylistsController : ControllerBase
    {

        private MusicContext _musicContext;

        [HttpGet]
        public IActionResult GetAllPlaylist([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            if (page <= 0 || pageSize <= 0)
            {
                return BadRequest("Invalid page or pageSize values");
            }

            var paginatedSongs = _musicContext.Playlists.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            return Ok(paginatedSongs);
        }


        [HttpGet("{id}")]
        public IActionResult GetPlaylist(int id) 
        {
            try
            {
                var playlist = _musicContext.Playlists.FirstOrDefault(s => s.Id == id);
                if (playlist == null)
                {
                    return NotFound("Song not found");
                }

                return Ok(playlist);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred");
            }

        }
    }
}
