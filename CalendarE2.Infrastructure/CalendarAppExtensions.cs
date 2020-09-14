using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CalendarE2
    .Infrastructure
{
    public static class CalendarAppExtensions
    {
        public static string TrimHourEtc(this string inDateStr)
        {
            return inDateStr.Substring(0, inDateStr.Length - 3);
        }
    }
}
