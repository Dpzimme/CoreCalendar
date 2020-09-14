using CalendarE2.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarE2.Domain.ViewModels
{
    public class StartDayViewModel
    {
        public int Yr { get; set; }
        public int Mo { get; set; }
        public int Day { get; set; }

        public string TimeFrame  {get; set; }

        public DateTime dT { get; set; }

        public string MoStr; 
        public StartDayViewModel(DateTime _dT, string _timeFrame)
        {
            this.Yr = _dT.Year;
            this.Mo = _dT.Month;
            this.Day = _dT.Day;
            this.dT = _dT;
            this.TimeFrame = _timeFrame;
            this.MoStr = MonthNames.MoNames[Mo];
        }
    }
}
