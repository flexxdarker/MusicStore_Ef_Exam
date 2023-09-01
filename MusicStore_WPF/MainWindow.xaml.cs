using Microsoft.EntityFrameworkCore;
using MusicStore_Ef_Exam.Data;
using MusicStore_Ef_Exam.Entities;
using MusicStore_Ef_Exam.Interfaces;
using MusicStore_Ef_Exam.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MusicStore_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IRepository<Album> _albumRepository = null;
        private IRepository<Seller> _sellerRepository = null;
        private IRepository<Buyer> _buyerRepository = null;
        private IRepository<Order> _orderRepository = null;
        private IRepository<Track> _trackRepository = null;
        private IRepository<Author> _authorRepository = null;
        public MainWindow()
        {
            InitializeComponent();
            var db = new MusicStoreDbContext();
            _albumRepository = new Repository<Album>(db);
            _authorRepository = new Repository<Author>(db); 
            _sellerRepository = new Repository<Seller>(db);
            _buyerRepository = new Repository<Buyer>(db);
            _orderRepository = new Repository<Order>(db);
            _trackRepository = new Repository<Track>(db);
        }

        private void ShowSellers_Selected(object sender, RoutedEventArgs e)
        {
            Grid.ItemsSource = _sellerRepository.Get().Select(x => new
            {
                x.Id,
                x.Name,
                x.Surname,
                x.Orders,
                x.Country,
            });
        }

        private void ShowOrders_Selected(object sender, RoutedEventArgs e)
        {
            Grid.ItemsSource = _orderRepository.Get().Select(x => new
            {
                x.Id,
                x.Buyer,
                x.Seller,
                x.OrderAlbums
            });
        }

        private void ShowBuyers_Selected(object sender, RoutedEventArgs e)
        {
            Grid.ItemsSource = _buyerRepository.Get().Select(x => new
            {
                x.Id,
                x.Name,
                x.Orders,
            });
        }

        private void ShowAuthors_Selected(object sender, RoutedEventArgs e)
        {
            Grid.ItemsSource = _authorRepository.Get().Select(x => new
            {
                x.Id,
                x.Name,
                x.Surname,
                x.Albums,
                x.Country
            });
        }

        private void ShowAlbums_Selected(object sender, RoutedEventArgs e)
        {
            Grid.ItemsSource = _albumRepository.Get().Select(x => new
            {
                x.Id,
                x.Name,
                x.Author,
                x.Category,
                x.Tracks,
                x.Year,
                x.OrderAlbums,
                x.Quantity,
                x.Price,
            });
        }

        private void AddAlbum_Selected(object sender, RoutedEventArgs e)
        {
            
        }

        private void AddAuthor_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void AddBuyer_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void AddOrder_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void AddSeller_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}
