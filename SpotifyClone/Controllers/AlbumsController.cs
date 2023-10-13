using Microsoft.AspNetCore.Mvc;
using SpotifyClone.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SpotifyClone.Controllers
{
  public class AlbumsController : Controller
  {
    private readonly SpotifyCloneContext _db;

    public AlbumsController(SpotifyCloneContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Album> model = _db.Albums.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Album newAlbum)
    {
      if (!ModelState.IsValid)
      {
        return View(newAlbum);
      }
      _db.Albums.Add(newAlbum);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Album album = _db.Albums.FirstOrDefault(databaseAlbums => databaseAlbums.AlbumId == id);
      return View(album);
    }

    public ActionResult Delete(int id)
    {
      Album album = _db.Albums.FirstOrDefault(databaseAlbums => databaseAlbums.AlbumId == id);
      return View(album);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Album album = _db.Albums.FirstOrDefault(databaseAlbums => databaseAlbums.AlbumId == id);
      _db.Albums.Remove(album);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
