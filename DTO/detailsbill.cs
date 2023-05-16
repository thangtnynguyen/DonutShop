using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class detailsbill
    {
        private string idsupllies;
        private string idbill;
        private int number;
        private int price;

        public detailsbill(string idsupllies, string idbill, int number, int price)
        {
            this.Idsupllies = idsupllies;
            this.Idbill = idbill;
            this.Number = number;
            this.Price = price;
        }

        public string Idsupllies { get => idsupllies; set => idsupllies = value; }
        public string Idbill { get => idbill; set => idbill = value; }
        public int Number { get => number; set => number = value; }
        public int Price { get => price; set => price = value; }
    }
}
