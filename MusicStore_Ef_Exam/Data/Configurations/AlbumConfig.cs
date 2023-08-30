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
    public class AlbumConfig : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x=>x.Quantity).IsRequired();
            builder.Property(x=>x.Price).IsRequired();
            builder.Property(x=>x.Year).IsRequired();
            builder.HasOne(x => x.Order).WithMany(x => x.Albums).HasForeignKey(x => x.OrderId);
            builder.HasOne(x => x.Author).WithMany(x => x.Albums).HasForeignKey(x => x.AuthorId);
            builder.HasOne(x => x.Category).WithMany(x => x.Albums).HasForeignKey(x => x.CategoryId);
            builder.HasMany(x => x.Tracks).WithOne(x => x.Albums).HasForeignKey(x => x.AlbumsId);
        }
    }
}
