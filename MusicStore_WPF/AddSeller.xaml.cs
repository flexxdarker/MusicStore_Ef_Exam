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
    /// Interaction logic for AddSeller.xaml
    /// </summary>
    public partial class AddSeller : Window
    {
        UnitOfWork UoW = new UnitOfWork();
        public AddSeller()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            UoW.SellerRepo.Insert(new Seller()
            { 
                Name = this.NameTextBox.Text,
                Surname = this.SurnameBox.Text,
                CountryId = Convert.ToInt32(this.CountryIdBox.Text)
            });
            UoW.Save();
            this.Close();
        }
    }
}
