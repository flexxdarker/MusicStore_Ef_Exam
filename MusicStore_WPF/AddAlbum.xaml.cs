using MusicStore_Ef_Exam.Entities;
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
using System.Windows.Shapes;

namespace MusicStore_WPF
{
    /// <summary>
    /// Interaction logic for AddAlbum.xaml
    /// </summary>
    public partial class AddAlbum : Window
    {
        UnitOfWork UoW = new UnitOfWork();
        public AddAlbum()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            UoW.AlbumRepo.Insert(new Album()
            {
                AuthorId = Convert.ToInt32(this.AuthorIdBox.Text),
                CategoryId = Convert.ToInt32(this.CategoryIdBox.Text),
                Name = this.NameBox.Text,
                Year = Convert.ToInt32(this.YearBox.Text),
                Quantity = Convert.ToInt32(this.QuantityBox.Text),
                Price = Convert.ToInt32(this.PriceBox.Text),
            });
            UoW.Save();
            this.Close();
        }
    }
}
