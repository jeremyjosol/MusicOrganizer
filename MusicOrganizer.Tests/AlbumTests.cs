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
  }
}