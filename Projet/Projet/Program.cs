using System;

namespace MNS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calendar calendar = new Calendar(2023, 20, Month.November, DayName.Monday);

            Alarm alarm1 = new Alarm("Debout les campeurs et haut les coeurs!");
            Alarm alarm2 = new Alarm("N'oublie pas d'aller acheter du pain");
            Alarm alarm3 = new Alarm("Il faut payer le loyer");
            Alarm alarm4 = new Alarm("Bonne année !");

            calendar.OnNewDay += alarm1.DisplayMessage;
            calendar.OnNewWeek += alarm2.DisplayMessage;
            calendar.OnNewMonth += alarm3.DisplayMessage;
            calendar.OnNewYear += alarm4.DisplayMessage;

            for (int i = 0; i < 300; i++)
            {
                calendar.NextDay();
                Console.WriteLine(calendar);
            }

            List<int> test = new List<int>();

            test.Where(nombre => nombre > 10);
        }
    }
}