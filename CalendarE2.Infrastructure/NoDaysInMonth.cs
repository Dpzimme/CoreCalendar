using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarE2.Infrastructure
{
    public static class NoDaysInMonth
    {
        public static int[] NoDays = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    public static bool isLeapYear(int yr)
        {
            if (yr % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static int GetNoDays(int yr, int mo)
        {
            if (mo == 2 && isLeapYear(yr))
            {
                return NoDays[mo] + 1;
            }
            else
            {
                return NoDays[mo];
            }
        }
    }
}
