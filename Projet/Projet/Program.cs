using Projet;
using System;

namespace MNS
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Meal> list = new List<Meal>();
            list.Add(new Meal(PRODUCTYPE.magicSalad, 5f));
            list.Add(new Meal(PRODUCTYPE.magicWrap, 8f));
            list.Add(new Meal(PRODUCTYPE.magicBurguer, 8f));
            list.Add(new Meal(PRODUCTYPE.magicGlace, 5f));
            list.Add(new Meal(PRODUCTYPE.magicWrap, 8f));

            Order order = new Order(list);
            float total=  order.getTotalePrice();
            Console.WriteLine("le prix totale des menus est de " + total);



        }
    }
}