using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsApp.SQLite
{
    public class Payslip
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        /// <summary>
        /// 年月情報
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// 出勤日数
        /// </summary>
        public int WorkDay { get; set; }

        /// <summary>
        /// 支給
        /// </summary>
        public int Supply { get; set; }

        /// <summary>
        /// 控除
        /// </summary>
        public int Deduction { get; set; }

        /// <summary>
        /// その他
        /// </summary>
        public int Other { get; set; }

        /// <summary>
        /// 総支給額
        /// </summary>
        public int Total { get; set; }

        public Payslip()
        {
            Date = new DateTime();
            WorkDay = 0;
            Supply = 0;
            Deduction = 0;
            Other = 0;
            Total = 0;
        }
    }
}

