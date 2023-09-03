using MusicStore_Ef_Exam.Data;
using MusicStore_Ef_Exam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore_Ef_Exam.Repositories
{
    public interface IUoW
    {
        Repository<Album> AlbumRepo { get; }
        Repository<Author> AuthorRepo { get; }
        Repository<Order> OrderRepo { get; }
        Repository<Buyer> BuyerRepo { get; }
        Repository<Seller> SellerRepo { get; }
        Repository<Track> TrackRepo { get; }
        void Save();
    }
    public class UnitOfWork : IDisposable, IUoW
    {
        private static MusicStoreDbContext context = new MusicStoreDbContext();
        private Repository<Album> albumRepo;
        private Repository<Author> authorRepo;
        private Repository<Order> orderRepo;
        private Repository<Buyer> buyerRepo;
        private Repository<Seller> sellerRepo;
        private Repository<Track> trackRepo;

        public Repository<Album> AlbumRepo
        {
            get
            {
                if (this.albumRepo == null)
                {
                    this.albumRepo = new Repository<Album>(context);
                }
                return albumRepo;
            }
        }

        public Repository<Author> AuthorRepo
        {
            get
            {

                if (this.authorRepo == null)
                {
                    this.authorRepo = new Repository<Author>(context);
                }
                return authorRepo;
            }
        }

        public Repository<Order> OrderRepo
        {
            get
            {

                if (this.orderRepo == null)
                {
                    this.orderRepo = new Repository<Order>(context);
                }
                return orderRepo;
            }
        }

        public Repository<Buyer> BuyerRepo
        {
            get
            {

                if (this.buyerRepo == null)
                {
                    this.buyerRepo = new Repository<Buyer>(context);
                }
                return buyerRepo;
            }
        }
        
        public Repository<Seller> SellerRepo
        {
            get
            {
                if(this.sellerRepo == null)
                {
                    this.sellerRepo = new Repository<Seller> (context);
                }
                return sellerRepo;
            }
        }
        
        public Repository<Track> TrackRepo
        {
            get
            {
                if(this.trackRepo == null)
                {
                    this.trackRepo = new Repository<Track> (context);
                }
                return trackRepo;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
