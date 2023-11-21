using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNS
{
    public class Alarm
    {
        public string Message { get; set; }

        public Alarm(string message)
        {
            Message = message ?? throw new ArgumentNullException(nameof(message));
        }

        public void DisplayMessage(object calendar, CalendarArgs calendarArgs)
        {
            Console.WriteLine($"{Message} - Date: {calendarArgs.DayName}, {calendarArgs.DayNumber}/{calendarArgs.Month}/{calendarArgs.Year}");
        }
    }
}
