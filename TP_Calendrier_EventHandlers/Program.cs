using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Calendrier_EventHandlers
{
    internal class Program
    {
        static void Main(string[] args) {

            Calendar calendar = new Calendar(2023, Dayname.Monday, Month.April, 20);

            Alarm alarm1 = new AlarmFixedDay("Bon anniversaire Thomas", 7, Month.April, 2024);
            Alarm alarm2 = new AlarmSpecificDay("tu dois te réveiller à 8h pour un entretien", Dayname.Monday);
            Alarm alarm3 = new Alarm("Il faut payer le loyer");
            Alarm alarm4 = new Alarm("Bonne année");


            calendar.OnNewDay += alarm1.DisplayMessage;
            calendar.OnNewWeek += alarm2.DisplayMessage;
            calendar.OnNewMonth += alarm3.DisplayMessage;
            calendar.OnNewYear += alarm4.DisplayMessage;


            for(int i = 0; i < 300; i++) {

                calendar.Nextday();
                Console.WriteLine(calendar);

            }
        }


    }

}


