using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    internal class Order
    {
        public List<Meal> listMeal{ get; set; }

        public Order(List<Meal> list)
        {
            this.listMeal = list;
        }



        public float getTotalePrice()
        {
            float totalPrice = 0;
            for (int i = 0; i < listMeal.Count; i++)

            {
                totalPrice+= listMeal[i].Price;
            }
            return totalPrice;
        }



    }
}
