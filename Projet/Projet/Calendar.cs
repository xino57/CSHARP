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

        public event Action OnNewDay;
        public event Action OnNewWeek;
        public event Action OnNewMonth;
        public event Action OnNewYear;

        public Calendar(int year, int dayNumber, Month month, DayName dayName)
        {
            Year = year;
            DayNumber = dayNumber;
            Month = month;
            DayName = dayName;
        }

        public void NextDay()
        {
            if (DayNumber >= 30)
            {
                DayNumber = 1;

                if (OnNewMonth != null)
                    OnNewMonth();

                if (Month >= Month.December)
                {
                    Month = Month.January;

                    Year++;

                    if (OnNewYear != null)
                        OnNewYear();
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
                    OnNewWeek();
                }
            }
            else
            {
                DayName++;
            }

            if (OnNewDay != null)
                OnNewDay();
        }

        public override string ToString()
        {
            return DayName + " " + DayNumber + " " + Month + " " + Year;
        }
    }
}
