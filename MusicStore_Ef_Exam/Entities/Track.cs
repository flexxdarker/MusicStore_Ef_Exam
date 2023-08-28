using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore_Ef_Exam.Entities
{
    public class Track
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int AlbumsId { get; set; }
        public Album Albums { get; set; }
        public int GanreId { get; set; }    
        public Ganre Ganre { get; set; }
    }
}
