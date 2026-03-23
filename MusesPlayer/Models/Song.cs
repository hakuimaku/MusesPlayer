using System;
using System.Collections.Generic;

namespace MusesPlayer.Models
{
    public class Song
    {
        public Song()
        {
            SongCategories = new List<SongCategory>();
            PlaylistSongs = new List<PlaylistSong>();
        }

        public string SongID { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public string AudioURL { get; set; }
        public int PlayCount { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ArtistID { get; set; }

        public Artist Artist { get; set; }
        public List<SongCategory> SongCategories { get; set; }
        public List<PlaylistSong> PlaylistSongs { get; set; }
    }
}