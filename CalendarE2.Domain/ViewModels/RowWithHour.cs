using CalendarE2.Domain;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CalendarE2.Domain.ViewModels
{
    public class RowWithHour
    {
        // Row with all the events of the same hour, with the date and hour 
        public List<EventVM> EventsOfHour;        
                     
        public int Hour;
        public string AMPM => (this.Hour > 11) ? "PM" : "AM";

        public int DisplayHour => (this.Hour > 12) ? this.Hour - 12 : this.Hour;       

        public RowWithHour(int i, List<EventVM> _events)
        {
            this.Hour = i;
            this.EventsOfHour = _events;
        }

        
        
    }
}
