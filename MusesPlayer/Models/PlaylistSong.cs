using System;

namespace MusesPlayer.Models
{
    public class PlaylistSong
    {
        public string PlaylistID { get; set; }
        public string SongID { get; set; }
        public DateTime AddedDate { get; set; }
        public int OrderNo { get; set; }

        public Playlist Playlist { get; set; }
        public Song Song { get; set; }
    }
}
```

Nếu bạn muốn, mình sẽ làm tiếp bước 2: tạo `IdGenerator` (ví dụ `AR0001`, `SG0001`, ...) + repository insert tự sinh ID để dùng ngay trong WinForms.