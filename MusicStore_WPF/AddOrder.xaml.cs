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
    /// Interaction logic for AddOrder.xaml
    /// </summary>
    public partial class AddOrder : Window
    {
        UnitOfWork UoW = new UnitOfWork();
        public AddOrder()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            UoW.OrderRepo.Insert(new Order()
            {
                Summ = Convert.ToInt32(this.SummBox.Text),
                BuyerId = Convert.ToInt32(this.BuyerIdBox.Text),
                SellerId = Convert.ToInt32(this.SellerIdBox.Text),
            });
            UoW.Save();
            this.Close();
        }
    }
}
