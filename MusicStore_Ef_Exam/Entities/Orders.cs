using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore_Ef_Exam.Entities
{
    public class Orders
    {
        public int Id { get; set; }
        public ICollection<Album> Albums { get; set; }
        public int BuyerId { get; set; }
        public Buyer Buyer { get; set; }
        public int SellerId { get; set; }
        public Seller Seller { get; set; }
        public decimal Summ { get; set; }
    }
}
