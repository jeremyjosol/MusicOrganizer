using System.Collections.Generic;
using Microsoft.AspNetCore.Http.Features;

namespace SpotifyClone.Models
{
  public class Album
  {
    public int AlbumId { get; set; }
    public string Title { get; set; }
    public string Artist { get; set; }
    public string ReleaseDate { get; set; }
    public string AlbumArtworkUrl { get; set; }
    public List<Song> Songs { get; set; }
  }
}