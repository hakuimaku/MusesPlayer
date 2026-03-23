using System.Collections.Generic;

namespace MusesPlayer.Models
{
    public class Category
    {
        public Category()
        {
            SongCategories = new List<SongCategory>();
        }

        public string CategoryID { get; set; }
        public string CategoryName { get; set; }

        public List<SongCategory> SongCategories { get; set; }
    }
}