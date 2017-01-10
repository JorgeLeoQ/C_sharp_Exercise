using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public struct Time
    {

        private readonly int minutes;
        private readonly int hours;
        private readonly int minutesTot; //minutes since midnight

        public Time(int hh, int mm)
        {
            this.minutes = mm;
            this.minutesTot = 60 * hh + mm;
            this.hours= hh;
        }
        public static Time operator +(Time t1,Time t2)
        {
            TimeSpan ts1 = new TimeSpan(t1.hours, t1.minutes,0);
            TimeSpan ts2 = new TimeSpan(t2.hours, t2.minutes,0);
            TimeSpan ts3 = ts1.Add(ts2);
            Time ris = new Time(ts3.Hours, ts3.Minutes);
           return ris;
        }
        public static Time operator -(Time t1, Time t2)
        {
            TimeSpan ts1 = new TimeSpan(t1.hours, t1.minutes, 0);
            TimeSpan ts2 = new TimeSpan(t2.hours, t2.minutes, 0);
            TimeSpan ts3 = ts1.Add(-ts2);
            Time ris = new Time(ts3.Hours, ts3.Minutes);
            return ris;
        }

        public static explicit operator int(Time t)
        {
            return t.minutesTot;
        }
        public static implicit operator Time(int minTot)
        {
            int hours=0;
            int min=minTot;
            while(min >= 60)
            {
                hours++;
                min -= 60;
            }
            Time ris = new Time(hours,min);
            return ris;
        }
        public override String ToString()
        {
            return String.Format("The time {0}:{1} corresponding at {2} total minutes", hours, minutes, minutesTot); 
        }
    }
}
