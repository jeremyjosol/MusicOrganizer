using System.Collections.Generic;

namespace SpotifyClone.Models
{
  public class Playlist
  {
    public int PlaylistId { get; set; }
    public string Title { get; set; }
    public List<Song> Songs { get; set; }
    public List<Album> Albums { get; set; }
  }
}