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
        public int Year { get; set; } = 0;
        public int Month { get; set; } = 0;
        public List<int> Day { get; set; } = new List<int> { 25, 26, 27, 28, 29, 30, 31 };
        public int SelectedDay = 0;
        public Payslip Payslip { get; private set; }
        public ReactiveProperty<string> ButtonText { get; private set; } = new ReactiveProperty<string>() { Value = "新規登録" };

        public ReactiveCommand SingUp { get; private set; } = new ReactiveCommand();

        public InputViewModel(Payslip payslip, Action action)
        {
            Year = payslip.Date.Year;
            Month = payslip.Date.Month;
            this.Payslip = payslip;
            SingUp.Subscribe(() =>
            {
                Payslip.WorkDay = SelectedDay;
                App.Database.SaveAsync(Payslip);
                action();
            });
            if(payslip.Id != 0)
            {
                ButtonText.Value = "　更新　"; 
            }
        }
    }
}
