using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bill
    {
        private string idbill;
        private string userid;
        private DateTime day;

        public Bill(string idbill, string userid, DateTime day)
        {
            this.Idbill = idbill;
            this.Userid = userid;
            this.Day = day;
        }

        public string Idbill { get => idbill; set => idbill = value; }
        public string Userid { get => userid; set => userid = value; }
        public DateTime Day { get => day; set => day = value; }
    }
}
