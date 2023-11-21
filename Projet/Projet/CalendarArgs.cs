using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNS
{
    public class CalendarArgs
    {
        public int Year { get; set; }
        public int DayNumber { get; set; }
        public Month Month { get; set; }
        public DayName DayName { get; set; }

        public CalendarArgs(int year, int dayNumber, Month month, DayName dayName)
        {
            Year = year;
            DayNumber = dayNumber;
            Month = month;
            DayName = dayName;
        }
        

    }
}


