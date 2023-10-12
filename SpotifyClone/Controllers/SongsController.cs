using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SpotifyClone.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SpotifyClone.Controllers
{
  public class SongsController : Controller
  {
    private readonly SpotifyCloneContext _db;

    public SongsController(SpotifyCloneContext db)
    {
       _db = db;
    }
    public ActionResult Index()
    {
      List<Song> model = _db.Songs.ToList(); 
      return View(model);
    }
    public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Song song)
    {
      if (!ModelState.IsValid)
      {
        return View(song);
      }      
      _db.Songs.Add(song); 
      _db.SaveChanges();  
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      Song song = _db.Songs.FirstOrDefault(song => song.SongId == id); 
      return View(song);
    }
    public ActionResult Delete(int id)
    {
      Song song = _db.Songs.FirstOrDefault(song => song.SongId == id); 
      return View(song);
    }
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Song song = _db.Songs.FirstOrDefault(song => song.SongId == id); 
      _db.Songs.Remove(song);
      _db.SaveChanges();     
      return RedirectToAction("Index");
    }
  }
}