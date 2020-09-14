using CalendarE2.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalendarE2.Domain.ViewModels
{
    public class PeriodViewModel 
    {        
        public int Yr;
        public int Mo;
        public string MoStr;
        public int Day;
        public int TimeFrame;

        // Period could be Day, Week or Month
        //public List<RowWithHour> Schedule { get; set; }
        public HeadersAndRows Schedule { get; set; }

        public PeriodViewModel(DateTime _dT, int _timeFrame)  
        {                            
            this.Yr = _dT.Year;
            this.Mo = _dT.Month;
            this.Day = _dT.Day;
            this.MoStr = MonthNames.MoNames[Mo - 1];
            this.TimeFrame = _timeFrame;
        }        
    }
}

