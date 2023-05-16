using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Donut
    {
        private string donutname;
        private byte[] donutimage;
        private int donutprice;

        public string Donutname { get => donutname; set => donutname = value; }
        public byte[] Donutimage { get => donutimage; set => donutimage = value; }
        public int Donutprice { get => donutprice; set => donutprice = value; }

        public Donut(string donutname, byte[] donutimage, int donutprice)
        {
            this.Donutname = donutname;
            this.Donutimage = donutimage;
            this.Donutprice = donutprice;
        }

        public Donut(DataRow row)
        {
            this.Donutname = row["donutname"].ToString();
            this.Donutimage = (byte[])row["donutimg"];
            this.Donutprice = (int)row["donutprice"];
        }
    }
}
