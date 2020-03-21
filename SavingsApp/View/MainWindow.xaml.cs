using MahApps.Metro.Controls;
using SavingsApp.ViewModel;
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

namespace SavingsApp
{
    /// <summary>
    /// Window1.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
            Year.SelectedItem = DateTime.Now.Year;
            Month.SelectedItem = DateTime.Now.Month;
        }
        private void Year_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var i = DataContext as MainViewModel;
            i.SelectedYear = (int)Year.SelectedItem;
        }

        private void Month_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var i = DataContext as MainViewModel;
            i.SelectedMonth = (int)Month.SelectedItem;
        }
    }
}
