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
    /// Interaction logic for AddBuyer.xaml
    /// </summary>
    public partial class AddBuyer : Window
    {
        UnitOfWork UoW = new UnitOfWork();
        public AddBuyer()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            UoW.BuyerRepo.Insert(new Buyer()
            {
                Name = this.NameBox.Text,
            });
            UoW.Save();
            this.Close();
        }
    }
}
