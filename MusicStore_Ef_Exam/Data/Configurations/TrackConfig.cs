using Microsoft.EntityFrameworkCore;
using MusicStore_Ef_Exam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore_Ef_Exam.Data.Configurations
{
    public class TrackConfig : IEntityTypeConfiguration<Track>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Track> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Name).IsRequired();
            builder.Property(x=>x.Duration).IsRequired();
            builder.HasOne(x => x.Albums).WithMany(x => x.Tracks).HasForeignKey(x => x.AlbumsId);
            builder.HasOne(x => x.Ganre).WithMany(x => x.Tracks).HasForeignKey(x => x.AlbumsId);
        }
    }
}
