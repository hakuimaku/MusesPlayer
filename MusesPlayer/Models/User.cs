using System.Collections.Generic;

namespace MusesPlayer.Models
{
    public class User
    {
        public User()
        {
            Playlists = new List<Playlist>();
        }

        public string UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public List<Playlist> Playlists { get; set; }
    }
}