using MusicStore_Ef_Exam.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore_Ef_Exam.Entities
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public decimal Summ { get; set; }
        public int BuyerId { get; set; }
        public virtual Buyer Buyer { get; set; }
        public int SellerId { get; set; }
        public virtual Seller Seller { get; set; }
        public virtual ICollection<OrderAlbums> OrderAlbums { get; set; }
    }
}
