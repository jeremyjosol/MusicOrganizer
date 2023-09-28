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
  
    public Album(string albumName)
    {
      Name = albumName;
      _instances.Add(this);
      Id = _instances.Count;
      Songs = new List<Song>{};
    }
    public Album(string albumName, List<Song> tracklist)
    {
      Name = albumName;
      Songs = tracklist;
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