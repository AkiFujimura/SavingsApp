using Reactive.Bindings;
using SavingsApp.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsApp.ViewModel
{
    public class InputViewModel
    {
        public List<int> Year { get; set; } = new List<int>();
        public List<int> Month { get; set; } = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        public List<int> Day { get; set; } = new List<int> { 25, 26, 27, 28, 29, 30, 31 };
        public Payslip Payslip { get; private set; }
        public string ButtonText { get; private set; } = "新規登録";

        public ReactiveCommand Button_Click { get; private set; } = new ReactiveCommand();

        public InputViewModel(Payslip payslip)
        {
            var toYear = DateTime.Now;
            for (int i = 1990; i <= toYear.Year; i++)
            {
                Year.Add(i);
            }

        }
    }
}
