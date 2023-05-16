using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ingredient
    {
        private string iddonut;
        private string idsupllies;
        private float number;

        public Ingredient(string iddonut, string idsupllies, float number)
        {
            this.Iddonut = iddonut;
            this.Idsupllies = idsupllies;
            this.Number = number;
        }

        public string Iddonut { get => iddonut; set => iddonut = value; }
        public string Idsupllies { get => idsupllies; set => idsupllies = value; }
        public float Number { get => number; set => number = value; }
    }
}
