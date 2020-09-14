using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarE2.Infrastructure
{
    public static class GetStartOfPeriod
    {

        // for getting the start of the week selected, how to count back to the starting sunday 
        private static Dictionary<string, int> dayOfWeekFromSunday = new Dictionary<string, int>()
        {
            ["Sunday"] = 0,
            ["Monday"] = 1,
            ["Tuesday"] = 2,
            ["Wednesday"] = 3,
            ["Thursday"] = 4,
            ["Friday"] = 5,
            ["Saturday"] = 6
        };

        public static DateTime getStartDateOfWeek(DateTime dT)
        {
            DateTime dTStartOfPeriod;
            
            // get sunday of the week.                
            bool found = dayOfWeekFromSunday.TryGetValue(dT.DayOfWeek.ToString(), out int daysFromSundayProvider);
            if (found)
            {
                int daysFromSunday = daysFromSundayProvider * (-1);
                dTStartOfPeriod = dT.AddDays(daysFromSunday);
                return dTStartOfPeriod;
            }
            else
            {
                throw  new System.ArgumentException("Cannot find start date of week"); 
            }
        }

        public static DateTime getStartDateOfMonth(DateTime dT)
        {
            int numbDays = (-1) * dT.Day; 
            return dT.AddDays(numbDays);
        }



    }
}
