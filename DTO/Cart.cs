using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Cart
    {
        private string username;
        private string donutname;
        private string status;
        private int number;
        private int price;
       

        public Cart(string username, string donutname, string status, int number,int price)
        {
            this.username = username;
            this.donutname = donutname;
            this.status = status;
            this.number = number;
            this.price = price;
        }

        public string Username { get => username; set => username = value; }
        public string Donutname { get => donutname; set => donutname = value; }
        public string Status { get => status; set => status = value; }
        public int Number { get => number; set => number = value; }
        public int Price { get => price; set => price = value; }


        public Cart(DataRow row)
        {
            this.username = row["ghuserid"].ToString();
            this.donutname = row["ghdonutid"].ToString();
            this.status = row["ghstatus"].ToString();
            this.number = (int)row["sl"];
        }
    }
}
