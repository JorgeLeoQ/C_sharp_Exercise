using System;

namespace Exercise4
{
    public class Workdays
    {
        //standard holidays in Italy
        static public DateTime[] holidays = new DateTime[]
        {
            new DateTime(DateTime.Now.Year, 1, 1),
            new DateTime(DateTime.Now.Year, 1, 6),
            new DateTime(DateTime.Now.Year, 4, 25),
            new DateTime(DateTime.Now.Year, 5, 1),
            new DateTime(DateTime.Now.Year, 6, 1),
            new DateTime(DateTime.Now.Year, 8, 15),
            new DateTime(DateTime.Now.Year, 11, 1),
            new DateTime(DateTime.Now.Year, 12, 8),
            new DateTime(DateTime.Now.Year, 12, 25),
            new DateTime(DateTime.Now.Year, 12, 26)
        };

        //I've supposed that every first saturday of the mouth is a workday in 2016
        static public DateTime[] workSaturdays = new DateTime[]
        {
            new DateTime(DateTime.Now.Year, 1, 2),
            new DateTime(DateTime.Now.Year, 2, 6),
            new DateTime(DateTime.Now.Year, 3, 5),
            new DateTime(DateTime.Now.Year, 4, 2),
            new DateTime(DateTime.Now.Year, 5, 7),
            new DateTime(DateTime.Now.Year, 6, 4),
            new DateTime(DateTime.Now.Year, 7, 2),
            new DateTime(DateTime.Now.Year, 9, 3),
            new DateTime(DateTime.Now.Year, 10, 1),
            new DateTime(DateTime.Now.Year, 11, 5),
            new DateTime(DateTime.Now.Year, 12, 3)
        };


        static public int HowManyDays(DateTime startDay, DateTime endDay)
        {
            int days = 1 + (int)(endDay - startDay).TotalDays;
            int weeks = days / 7;
            int remainderDays = days % 7;

            //if a week is halved.
            if (7 - remainderDays <= (int)startDay.DayOfWeek)
                days--;
            if (7 - remainderDays <= (int)startDay.DayOfWeek)
                days--;

            // loop that find holiday in the range days.
            for (int yearAtt = startDay.Year; yearAtt <= endDay.Year; yearAtt++)
            {
                foreach (DateTime dateCandidate in holidays)
                {
                    DateTime tryDate = new DateTime(yearAtt, dateCandidate.Month, dateCandidate.Day);
                    if ((tryDate.DayOfWeek != DayOfWeek.Saturday) && (tryDate.DayOfWeek != DayOfWeek.Sunday) && (tryDate >= startDay) && (tryDate <= endDay))
                    {
                        days--;
                    }
                }
            }

            days -= weeks * 2; //add two day (saturday and sunday) per week. 

            // loop that find working saturdays and add at total sum of day work.
            for (int yearAtt = startDay.Year; yearAtt <= endDay.Year; yearAtt++)
            {
                foreach (DateTime dateCandidate in workSaturdays)
                {
                    DateTime tryDate = new DateTime(yearAtt, dateCandidate.Month, dateCandidate.Day);
                    if ((tryDate.DayOfWeek == DayOfWeek.Saturday) && (tryDate <= endDay) && (tryDate >= startDay))
                    {
                        days++;
                    }
                }
            }
            return days;
        }

        static void Main(string[] args)
        {
        }
    }
}
