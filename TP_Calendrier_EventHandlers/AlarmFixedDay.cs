using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Calendrier_EventHandlers
{
    internal class AlarmFixedDay: Alarm
    {
        public  int DayNumber { get; set; }
        public Month Month { get; set; }
        public int Year { get; set; }
        public string Message { get; set; }


        public AlarmFixedDay(string message, int dayNumber, Month month, int year)

        {
            Message = message;
            DayNumber = dayNumber;
            Month = month;
            Year = year;
        }


        public override void DisplayMessage (object sender, CalendarArgs calendarArgs)
        {
            if (calendarArgs.Years == Year && calendarArgs.Month == Month && calendarArgs.DayNumber == DayNumber) {

                base.DisplayMessage(sender, calendarArgs);
            }
        }
    }
}
