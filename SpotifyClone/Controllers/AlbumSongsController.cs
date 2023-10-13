using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using SpotifyClone.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SpotifyClone.Controllers
{
  public class AlbumSongsController : Controller
  {
    private readonly SpotifyCloneContext _db;
    public AlbumSongsController(SpotifyCloneContext db)
    {
      _db = db;
    }

    public ActionResult AddSongToAlbum(int id)
    {
        Song songToAddToAlbum = _db.Songs.FirstOrDefault(databaseSongs => databaseSongs.SongId == id);
        ViewBag.AlbumId = new SelectList(_db.Albums, "AlbumId", "Title");
        ViewBag.SongId = new SelectList(_db.Songs, "SongId", "Title");
        return View(songToAddToAlbum);
    }
    [HttpPost]
    public ActionResult AddSongToAlbum(Song song, int albumId)
    {
      if (albumId != 0)
      {
        Album album = _db.Albums.Include(databaseAlbums => databaseAlbums.Songs).FirstOrDefault(databaseAlbums => databaseAlbums.AlbumId == albumId);
        if (album != null)
        {
          album.Songs.Add(song);
          _db.SaveChanges();
        }
      }
      return RedirectToAction("Details", new { id = albumId });
    }
  } 
}