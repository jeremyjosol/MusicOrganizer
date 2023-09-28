# Music Organizer

This application is a simple demonstration of managing and organizing a user's music collection. It was designed to help practice working with nested objects in C#, specifically the concept of parent/child relationships.

This Music Organizer allows a user to:

* **Create and manage albums**
  > _Add albums by specifying their names and artists_.
* **Add songs to albums**
  > _Populate each album with its corresponding song titles_.
* **Explore discography** 
  > _View a list of all albums, songs, and artists_.
* **Search by artist**
  > _Work in progress_.

## Application Setup

1. Clone this repo.
2. Open your shell (e.g., Terminal or GitBash) and navigate to this project's production directory called `MusicOrganizer`. 
3. Run `dotnet run`.
4. Open the browser to `http://localhost:5000` or `https://localhost:5001`.

## Available Routes

* localhost:5000/
* localhost:5000/albums
* localhost:5000/albums/new
* localhost:5000/albums/{id}
* localhost:5000/albums/{id}/songs
* localhost:5000/albums/{id}/songs/new
* localhost:5000/albums/{id}/songs/{id}
