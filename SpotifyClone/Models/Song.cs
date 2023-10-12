using System.Collections.Generic;

namespace SpotifyClone.Models
{
public class Song
{
    public int SongId { get; set; }
    public string Title { get; set; }
    public string Artist { get; set; }
    public string AlbumArtworkUrl { get; set; }
    // public int AlbumId { get; set; }
    // public Album Album { get; set; }
  }
}