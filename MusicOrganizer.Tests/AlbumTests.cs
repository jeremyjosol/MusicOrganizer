using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class AlbumTests : IDisposable
  {
    public void Dispose()
    {
      Album.ClearAll();
    }
    [TestMethod]
    public void AlbumConstructor_CreatesInstanceOfAlbum_Album()
    {
      Album newAlbum = new Album("Test album");
      Assert.AreEqual(typeof(Album), newAlbum.GetType());
    }
    [TestMethod]
    public void AlbumName_ReturnsAlbumName_String()
    {
      string albumName = "Black Metal";
      Album newAlbum = new Album(albumName);
      string result = newAlbum.Name;
      Assert.AreEqual(albumName, result);
    }
    [TestMethod]
    public void AlbumId_ReturnsAlbumId_Int()
    {
      string albumName = "Black Metal";
      Album newAlbum = new Album(albumName);
      int result = newAlbum.Id;
      Assert.AreEqual(1, result);
    }
  }
}