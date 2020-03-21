using SavingsApp.SQLite;
using SavingsApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SavingsApp.View
{
    /// <summary>
    /// InputWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class InputWindow : Window
    {
        public InputWindow(Payslip payslip)
        {
            InitializeComponent();
            this.DataContext = new InputViewModel(payslip);
            this.Year.SelectedItem = DateTime.Now.Year;
            this.Month.SelectedItem = DateTime.Now.Month;
            this.Day.SelectedItem = 30;
        }


        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !new Regex("[0-9]").IsMatch(e.Text);
        }

    }
}
