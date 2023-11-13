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

            // Passage par référence
            int secondes = 329;
            int minutes = 800;
            int heures = 8000;

            TimeConversion(ref secondes, ref minutes, ref heures);
            Console.WriteLine(heures + "H" + minutes +"min" + secondes +"s");
            
          static void TimeConversion (ref int secondes, ref int minutes, ref int heures) {

                secondes = secondes + minutes + heures;

                if (secondes / 3600 > 0)
                {
                    heures = secondes / 3600;
                    secondes = secondes % 3600;

                }else
                {
                    heures = 0;
                }
                if(secondes / 60 > 0)
                {
                    minutes = secondes / 60;
                    secondes = secondes % 60;
                }
                else{
                    minutes = 0; 
                }

            }


            // test spatify
            Spatify.Test();
            



        }
    }
}