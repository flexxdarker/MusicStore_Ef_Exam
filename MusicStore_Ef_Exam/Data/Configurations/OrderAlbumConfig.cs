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
    public class OrderAlbumConfig : IEntityTypeConfiguration<OrderAlbums>
    {
        public void Configure(EntityTypeBuilder<OrderAlbums> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Album).WithMany(x => x.OrderAlbums).HasForeignKey(x => x.AlbumId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Order).WithMany(x => x.OrderAlbums).HasForeignKey(x => x.OrderId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
