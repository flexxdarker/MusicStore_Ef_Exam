using MusicStore_Ef_Exam.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore_Ef_Exam.Entities
{
    public class Country : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Author> Author { get; set; }
        public virtual ICollection<Seller> Seller { get; set; }
    }
}
