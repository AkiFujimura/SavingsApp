using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SavingsApp
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        static SQLite.SQLite database;

        public static SQLite.SQLite Database
        {
            get
            {
                if (database == null)
                {
                    database = new SQLite.SQLite(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SavingsApp.db3"));
                }
                return database;
            }
        }
    }
}
