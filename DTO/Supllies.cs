using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Supllies
    {
        protected string name;
        private int soluong;

        public string Name { get => name; set => name = value; }
        public int Soluong { get => soluong; set => soluong = value; }

        public Supllies(string name,int soluong)
        {
            this.Name = name;
            this.soluong = soluong;
        }
    }
}
