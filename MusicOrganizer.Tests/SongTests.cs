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
    [TestMethod]
    public void GetAll_ReturnsSongs_SongList()
    {
      string songTitle01 = "Forever";
      string songTitle02 = "Country";
      Song newSong1 = new Song(songTitle01);
      Song newSong2 = new Song(songTitle02);
      List<Song> newList = new List<Song> { newSong1, newSong2 };
      List<Song> result = Song.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}