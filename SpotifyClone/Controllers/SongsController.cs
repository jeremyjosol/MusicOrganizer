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
      List<Song> model = Song.GetAll().ToList(); 
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
      song.Save();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      Song song = Song.Find(id);
      return View(song);
    }
    public ActionResult Delete(int id)
    {
      Song song = Song.Find(id);
      return View(song);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Song song = Song.Find(id);
      song.Remove(song);
      return RedirectToAction("Index");
    }
  }
}
