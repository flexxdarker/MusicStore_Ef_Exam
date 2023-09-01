using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore_Ef_Exam.Entities
{
    public class OrderAlbums
    {
        public int Id { get; set; }
        public int AlbumId { get; set; }
        public virtual Album Album { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
