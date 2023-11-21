using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNS
{
    public class Calendar
    {
        public int Year { get; set; }
        public int DayNumber { get; set; }
        public Month Month { get; set; }
        public DayName DayName { get; set; }

        public event EventHandler<CalendarArgs> OnNewDay;
        public event EventHandler<CalendarArgs> OnNewWeek;
        public event EventHandler<CalendarArgs> OnNewMonth;
        public event EventHandler<CalendarArgs> OnNewYear;

        public Calendar(int year, int dayNumber, Month month, DayName dayName)
        {
            Year = year;
            DayNumber = dayNumber;
            Month = month;
            DayName = dayName;
        }

        public void NextDay()
        {
            CalendarArgs calendarArgs = new CalendarArgs(2023, 1, Month.November, DayName.Friday);
            if (DayNumber >= 30)
            {
                DayNumber = 1;

                if (OnNewMonth != null)
                {
                    OnNewMonth(this, calendarArgs);
                }

                if (Month >= Month.December)
                {
                    Month = Month.January;

                    Year++;

                    if (OnNewYear != null)
                        OnNewYear(this, calendarArgs);
                }
                else
                {
                    Month++;
                }
            }
            else
            {
                DayNumber++;
            }

            if (DayName >= DayName.Sunday)
            {
                DayName = DayName.Monday;

                if (OnNewWeek != null)
                {
                    OnNewYear(this, calendarArgs);
                }
            }
            else
            {
                DayName++;
            }

            if (OnNewDay != null)
                OnNewYear(this, calendarArgs);
        }

        public override string ToString()
        {
            return $"{DayName} {DayNumber} {Month} {Year}";
        }

    }
}
