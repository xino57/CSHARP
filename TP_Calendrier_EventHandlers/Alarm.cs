using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Calendrier_EventHandlers
{
    internal class Alarm
    {
        public Alarm()
        {
        }

        public string Message { get; set; }

        public Alarm(string message)
        {
            Message = message ?? throw new ArgumentNullException(nameof(message));
        }

        public virtual void DisplayMessage(object sender, CalendarArgs calendarArgs)
        {
            Console.WriteLine(Message);
        }
    }

}


