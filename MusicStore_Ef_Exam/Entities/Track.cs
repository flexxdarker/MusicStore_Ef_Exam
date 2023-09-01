using MusicStore_Ef_Exam.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore_Ef_Exam.Entities
{
    public class Track : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int AlbumsId { get; set; }
        public virtual Album Albums { get; set; }
        public int GanreId { get; set; }    
        public virtual Ganre Ganre { get; set; }
    }
}
