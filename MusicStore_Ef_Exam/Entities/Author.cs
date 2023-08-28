using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore_Ef_Exam.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Surname { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
