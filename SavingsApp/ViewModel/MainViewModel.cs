using Reactive.Bindings;
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
        public string ToMonth { get; private set; } = "Hello World !!";
        public ReactiveCommand Button_Click { get; set; } = new ReactiveCommand();
        public MainViewModel()
        {
            Button_Click.Subscribe(() =>
            {
                var Window = new InputWindow();
                Window.Show();
            });
        }

    }
}
