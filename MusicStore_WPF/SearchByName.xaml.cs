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
    /// Interaction logic for SearchByName.xaml
    /// </summary>
    public partial class SearchByName : Window
    {
        UnitOfWork UoW = new UnitOfWork();
        public SearchByName()
        {
            InitializeComponent();
            DataGrid.ItemsSource = UoW.TrackRepo.Get().Select(x => new {x.Name, x.Duration}).ToList();
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Search.Text == "")
            {
                DataGrid.ItemsSource = UoW.TrackRepo.Get().Select(x=> new {x.Name, x.Duration});
            }
            else
            {
                DataGrid.ItemsSource = UoW.TrackRepo.Get().Select(x => new {x.Name,x.Duration}).Where(x=>x.Name.StartsWith(Search.Text)).ToList();
            }
        }
    }
}
