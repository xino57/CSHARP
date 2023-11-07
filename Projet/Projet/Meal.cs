using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    internal class Meal
    {
        public PRODUCTYPE ProductType { get; set; }
        public float Price { get; set; }

        public Meal(PRODUCTYPE ProducType, float Price)
        {
            this.ProductType = ProducType;
            this.Price = Price;
        }
    }
}
