using MusicStore_Ef_Exam.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore_Ef_Exam.Entities
{
    public class Album : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int Year { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderAlbums> OrderAlbums { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
    }
}
