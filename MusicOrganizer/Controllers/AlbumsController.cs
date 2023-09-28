using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;

namespace MusicOrganizer.Controllers
{
  public class AlbumsController : Controller
  {
    [HttpGet("/albums")]
    public ActionResult Index()
    {
      List<Album> allAlbums = Album.GetAll();
      return View(allAlbums);
    }
  }
}