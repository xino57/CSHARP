using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TP_Calendrier_EventHandlers
{
    internal class Calendar
    {

        public event EventHandler<CalendarArgs> OnNewDay;
        public event EventHandler<CalendarArgs> OnNewWeek;
        public event EventHandler<CalendarArgs> OnNewMonth;
        public event EventHandler<CalendarArgs> OnNewYear;

        public int Years { get; set; }
        public int DayNumber { get; set; }
        public Dayname DayName { get; set; }
        public Month Month { get; set; }



        public Calendar(int years, Dayname dayName, Month month, int dayNumber)
        {
            Years = years;
            DayName = dayName;
            Month = month;
            DayNumber = dayNumber;
        }

        public void Nextday()
        {
            if (DayNumber >= 30)
            {
                DayNumber = 1;

                if (OnNewMonth != null)
                    OnNewMonth(this, new CalendarArgs(Years, DayNumber, Month, DayName));

                if (Month >= Month.December)
                {
                    Month = Month.January;

                    Years++;

                    if (OnNewYear != null)
                        OnNewYear(this, new CalendarArgs(Years, DayNumber, Month, DayName));

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

            if (DayName >= Dayname.Sunday)
            {
                DayName = Dayname.Monday;

                OnNewWeek?.Invoke(this, new CalendarArgs(Years, DayNumber, Month, DayName));
            }
            else
            {
                DayName++;
            }

            OnNewDay?.Invoke(this, new CalendarArgs(Years, DayNumber, Month, DayName));
        }

        public override string ToString()
        {
            return DayName + " " + DayNumber + " " + Month + " " + Years;
        }
    }
}
