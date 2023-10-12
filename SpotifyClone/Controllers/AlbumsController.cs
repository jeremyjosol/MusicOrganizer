// using System.Collections.Generic;
// using System;
// using Microsoft.AspNetCore.Mvc;
// using SpotifyClone.Models;

// namespace SpotifyClone.Controllers
// {
//   public class AlbumsController : Controller
//   {
//     [HttpGet("/albums")]
//     public ActionResult Index()
//     {
//       List<Album> allAlbums = Album.GetAll();
//       return View(allAlbums);
//     }
//     [HttpGet("/albums/new")]
//     public ActionResult New()
//     {
//       return View();
//     }
//     [HttpPost("/albums")]
//     public ActionResult Create(string albumName, string artistName)
//     {
//       Console.WriteLine($"Album Name: {albumName}");
//       Console.WriteLine($"Artist Name: {artistName}");
//       Album newAlbum = new Album(albumName, artistName);
//       return RedirectToAction("Index");
//     }
//     [HttpGet("/albums/{id}")]
//     public ActionResult Show(int id)
//     {
//       Dictionary<string, object> model = new Dictionary<string, object>();
//       Album selectedAlbum = Album.Find(id);
//       List<Song> albumSongs = selectedAlbum.Songs;
//       model.Add("album", selectedAlbum);
//       model.Add("songs", albumSongs);
//       return View(model);
//     }
//     [HttpPost("/albums/{albumId}/songs")]
//     public ActionResult Create(int albumId, string songTitle)
//     {
//       Dictionary<string, object> model = new Dictionary<string, object>();
//       Album foundAlbum = Album.Find(albumId);
//       Song newSong = new Song(songTitle);
//       foundAlbum.AddSong(newSong);
//       List<Song> albumSongs = foundAlbum.Songs;
//       model.Add("songs", albumSongs);
//       model.Add("album", foundAlbum);
//       return View("Show", model);
//     }
//   }
// }