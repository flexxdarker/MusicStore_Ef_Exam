using Microsoft.EntityFrameworkCore;
using MusicStore_Ef_Exam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore_Ef_Exam.Data
{
    public class MusicStoreDbContext : DbContext
    {
        public MusicStoreDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;";
            optionsBuilder.UseSqlServer(conn);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(new[]
            {
                new Country() {Id = 1, Name = "Ukraine"},
                new Country() {Id = 2, Name = "Poland"},
                new Country() {Id = 3, Name = "Brazil"},
                new Country() {Id = 4, Name = "Germany"}
            });
            modelBuilder.Entity<Category>().HasData(new[]
            {
                new Category() {Id = 1, Name = "Pop"},
                new Category() {Id = 2, Name = "Jazz"},
                new Category() {Id = 3, Name = "Rock"},
                new Category() {Id = 4, Name = "Metalic"},
                new Category() {Id = 5, Name = "Hip-Hop"}
            });
            modelBuilder.Entity<C>

        }
    }
}
