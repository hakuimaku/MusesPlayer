namespace MusesPlayer.Models
{
    public class SongCategory
    {
        public string SongID { get; set; }
        public string CategoryID { get; set; }

        public Song Song { get; set; }
        public Category Category { get; set; }
    }
}