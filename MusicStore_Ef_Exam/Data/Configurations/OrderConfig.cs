using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicStore_Ef_Exam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore_Ef_Exam.Data.Configurations
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Summ).IsRequired();
            builder.HasOne(x => x.Seller).WithMany(x => x.Orders).HasForeignKey(x => x.SellerId);
            builder.HasOne(x => x.Buyer).WithMany(x => x.Orders).HasForeignKey(x => x.BuyerId);
            
        }
    }
}
