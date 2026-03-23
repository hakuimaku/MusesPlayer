using System;
using System.Collections.Generic;

namespace MusesPlayer.Models
{
    public class Playlist
    {
        public Playlist()
        {
            PlaylistSongs = new List<PlaylistSong>();
        }

        public string PlaylistID { get; set; }
        public string PlaylistName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UserID { get; set; }

        public User User { get; set; }
        public List<PlaylistSong> PlaylistSongs { get; set; }
    }
}