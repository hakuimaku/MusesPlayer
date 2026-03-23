using System.Collections.Generic;

namespace MusesPlayer.Models
{
    public class Artist
    {
        public Artist()
        {
            Songs = new List<Song>();
        }

        public string ArtistID { get; set; }
        public string ArtistName { get; set; }
        public string Bio { get; set; }
        public string AvatarURL { get; set; }

        public List<Song> Songs { get; set; }
    }
}