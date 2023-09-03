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
        UnitOfWork UoW = new UnitOfWork();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowSellers_Selected(object sender, RoutedEventArgs e)
        {

            Grid.ItemsSource = UoW.SellerRepo.Get(includeProperties: "Orders,Country").Select(x => new
            {
                x.Id,
                x.Name,
                x.Surname,
                Country = x.Country.Name
            });
        }

        private void ShowOrders_Selected(object sender, RoutedEventArgs e)
        {
            Grid.ItemsSource = UoW.OrderRepo.Get(includeProperties: "Seller,Buyer").Select(x => new
            {
                x.Id,
                Buyer = x.Buyer.Name,
                Seller = x.Seller.Name,
            });
        }

        private void ShowBuyers_Selected(object sender, RoutedEventArgs e)
        {

            Grid.ItemsSource = UoW.BuyerRepo.Get().Select(x => new
            {
                x.Id,
                x.Name,
            });
        }

        private void ShowAuthors_Selected(object sender, RoutedEventArgs e)
        {
            Grid.ItemsSource = UoW.AuthorRepo.Get(includeProperties: "Country").Select(x => new
            {
                x.Id,
                x.Name,
                x.Surname,
                Country = x.Country.Name
            });
        }

        private void ShowAlbums_Selected(object sender, RoutedEventArgs e)
        {
            Grid.ItemsSource = UoW.AlbumRepo.Get(includeProperties: "Category,Author").Select(x => new
            {
                x.Id,
                x.Name,
                Author = x.Author.Name,
                Category = x.Category.Name,
                x.Year,
                x.Quantity,
                x.Price,
            });
        }

        private void AddAlbum_Selected(object sender, RoutedEventArgs e)
        {
            AddAlbum addAlbum = new AddAlbum();
            addAlbum.ShowDialog();
        }

        private void AddAuthor_Selected(object sender, RoutedEventArgs e)
        {
            AddAuthor addAuthor = new AddAuthor();
            addAuthor.ShowDialog();
        }

        private void AddBuyer_Selected(object sender, RoutedEventArgs e)
        {
            AddBuyer addBuyer = new AddBuyer();
            addBuyer.ShowDialog();
        }

        private void AddOrder_Selected(object sender, RoutedEventArgs e)
        {
            AddOrder addOrder = new AddOrder();
            addOrder.ShowDialog();
        }

        private void AddSeller_Selected(object sender, RoutedEventArgs e)
        {
            AddSeller addSeller = new AddSeller();
            addSeller.ShowDialog();
        }

        private void SearchByName_Click(object sender, RoutedEventArgs e)
        {
            SearchByName searchByName = new SearchByName();
            searchByName.ShowDialog();
        }
    }
}
