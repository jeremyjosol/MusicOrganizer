using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MusicOrganizer.Models;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class SongTests : IDisposable
  {
    public void Dispose()
    {
      Song.ClearAll();
    }
    [TestMethod]
    public void SongConstructor_CreatesAndReturnsInstanceOfSongTitle_String()
    {
      string songTitle = "Forever";
      Song newSong = new Song(songTitle);
      string result = newSong.Title;
      Assert.AreEqual(songTitle, result);
    }
  }
}