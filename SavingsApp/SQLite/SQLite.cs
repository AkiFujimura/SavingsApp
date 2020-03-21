using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsApp.SQLite
{
    public class SQLite
    {
        readonly SQLiteAsyncConnection _database;

        public SQLite(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Payslip>().Wait();
        }

        public Task<List<Payslip>> GetsAsync()
        {
            return _database.Table<Payslip>().ToListAsync();
        }

        public Task<Payslip> GetAsync(int id)
        {
            return _database.Table<Payslip>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveAsync(Payslip payslip)
        {
            if (payslip.Id != 0)
            {
                return _database.UpdateAsync(payslip);
            }
            else
            {
                return _database.InsertAsync(payslip);
            }
        }

        public Task<int> DeleteAsync(Payslip payslip)
        {
            return _database.DeleteAsync(payslip);
        }

    }
}
