using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Calendrier_EventHandlers
{
    internal class AlarmSpecificDay: Alarm

    {
        public Dayname dayname { get; set; }

        public AlarmSpecificDay(string message, Dayname dayname) : base(message)
        {
            this.dayname = dayname;
        }

        public override void DisplayMessage(object sender, CalendarArgs calendarArgs)
        {
            if(calendarArgs.Dayname == dayname) { 
            
               base.DisplayMessage(sender, calendarArgs);
            }
        }
    }
}
