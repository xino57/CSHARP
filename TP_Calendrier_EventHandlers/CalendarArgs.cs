using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Calendrier_EventHandlers
{
    internal class CalendarArgs
    {
        public int Years { get; set; }
        public  int DayNumber { get; set; }

        public Month Month { get; set; }

        public Dayname Dayname { get; set; }

        public CalendarArgs(int years, int dayNumber, Month month, Dayname dayname)
        {
            Years = years;
            DayNumber = dayNumber;
            Month = month;
            Dayname = dayname;
        }
    }
}
