using Microsoft.EntityFrameworkCore;
using MusicStreamingApp.Models;
using System;

namespace MusicStreamingApp.Context
{
    public class MusicContext : DbContext
    {

        public DbSet<Song> Songs { get; set; }
        public DbSet<Playlist> Playlists { get; set; }

        public MusicContext(DbContextOptions<MusicContext> options) : base()
        {

        }

    }
}
