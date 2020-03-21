using Reactive.Bindings;
using SavingsApp.SQLite;
using SavingsApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SavingsApp.ViewModel
{
    public class MainViewModel
    {
        public List<int> Year { get; private set; } = new List<int>();
        public List<int> Month { get; private set; } = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        public int SelectedYear = 0;
        public int SelectedMonth = 0;
        public ReactiveCommand Button_Click { get; private set; } = new ReactiveCommand();
        public MainViewModel()
        {
            for (int i = 1990; i <= DateTime.Now.Year; i++)
            {
                Year.Add(i);
            }

            Button_Click.Subscribe(() =>
            {
                var payslip = new Payslip()
                {
                    Date =  new DateTime(SelectedYear,SelectedMonth,1)
                };
                var Window = new InputWindow(payslip);
                Window.Show();
            });
        }

    }
}
