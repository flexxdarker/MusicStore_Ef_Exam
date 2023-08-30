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
            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MusicStore;Integrated Security=True;Connect Timeout=30;";
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
                new Country() {Id = 4, Name = "Germany"},
                new Country() {Id = 5, Name = "USA"}
            });
            modelBuilder.Entity<Ganre>().HasData(new[]
            {
                new Ganre() {Id = 1, Name = "Pop"},
                new Ganre() {Id = 2, Name = "Jazz"},
                new Ganre() {Id = 3, Name = "Rock"},
                new Ganre() {Id = 4, Name = "Metalic"},
                new Ganre() {Id = 5, Name = "Hip-Hop"}
            });
            modelBuilder.Entity<Category>().HasData(new[]
            {
                new Category() {Id = 1, Name = "Relax"},
                new Category() {Id = 2, Name = "Dance"},
                new Category() {Id = 3, Name = "Work"},
                new Category() {Id = 4, Name = "Work Out"}
            });
            modelBuilder.Entity<Track>().HasData(new[]
            {
                new Track() {Id = 1, Name = "No Troubles", GanreId = 5, Duration = 240, AlbumsId = 1},
                new Track() {Id = 2, Name = "My Way", AlbumsId= 2, Duration = 210, GanreId = 1},
                new Track() {Id = 3, Name = "No More Tears", AlbumsId = 3, Duration = 400, GanreId = 3},
                new Track() {Id = 4, Name = "M.A.D.E", GanreId = 1, Duration = 200, AlbumsId = 2}
            });
            modelBuilder.Entity<Author>().HasData(new[] 
            { 
                new Author() {Id = 1, Name = "Watsebha", CountryId = 1},
                new Author() {Id = 2, CountryId = 2, Name = "Calvin", Surname = "Harris"},
                new Author() {Id = 3, CountryId = 5, Name = "Ozzy", Surname = "Osbourne"},
                new Author() {Id = 4, CountryId = 5, Name = "Lucky", Surname = "Luke"}
            });
            modelBuilder.Entity<Album>().HasData(new[]
            {
                new Album() {Id = 1, Name = "No Troubles", AuthorId = 1, CategoryId =1, Quantity = 5, Year = 2022, Price = 2, OrderId = 1},
                new Album() {Id = 2, Name = "My Way", AuthorId = 2, CategoryId = 2, Price = 5, Quantity = 20, Year = 2020, OrderId = 2},
                new Album() {Id = 3, Name = "No More Tears", AuthorId = 3, CategoryId = 3, Year = 2018, Quantity = 100, Price = 10, OrderId = 1 },
                new Album() {Id = 4, Name = "M.A.D.E.", AuthorId = 4, CategoryId = 4, Price = 25, Quantity = 15, Year = 2017, OrderId =1}
            });
            modelBuilder.Entity<Seller>().HasData(new[]
            {
                new Seller() {Id = 1, Name = "Oleksandr", CountryId = 1, Surname = "Polushovuch" },
                new Seller() {Id = 2, Name = "Dima", Surname = "Piatov", CountryId = 2}
            });
            modelBuilder.Entity<Buyer>().HasData(new[]
            {
                new Buyer() {Id = 1, Name = "Sviatoslav"},
                new Buyer() {Id = 2, Name = "Leonardo"}
            });
            modelBuilder.Entity<Order>().HasData(new[]
            {
                new Order() { Id = 1, BuyerId = 1, SellerId = 1, Summ = 200},
                new Order() { Id = 2, BuyerId = 2, SellerId = 2, Summ = 20}
            });
        }
    }
}
