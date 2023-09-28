using System.Collections.Generic;
using Microsoft.AspNetCore.Http.Features;

namespace MusicOrganizer.Models
{
  public class Album
  {
    private static List<Album> _instances = new List<Album> { };
    public string Name { get; set; }
    public int Id { get; }
    public List<Song> Songs { get; set; }
    public string Artist { get; set; }
  
    public Album(string albumName)
    {
      Name = albumName;
      Artist = null;
      _instances.Add(this);
      Id = _instances.Count;
      Songs = new List<Song>{};
    }
    // come back to this overload concept
    public Album(string albumName, string artistName)
    {
      Name = albumName;
      Artist = artistName;
      _instances.Add(this);
      Id = _instances.Count;
      Songs = new List<Song>{};
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Album> GetAll()
    {
      return _instances;
    }
    public static Album Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public void AddSong(Song song)
    {
      Songs.Add(song);
    }
  }
}