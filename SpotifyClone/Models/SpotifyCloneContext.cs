using Microsoft.EntityFrameworkCore;

namespace SpotifyClone.Models
{
  public class SpotifyCloneContext : DbContext
  {
    public DbSet<Album> Albums { get; set; }
    public DbSet<Song> Songs { get; set; }
    public DbSet<Playlist> Playlists { get; set; }

    public SpotifyCloneContext(DbContextOptions options) : base(options) { }
  }
}