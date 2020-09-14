using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalendarE2.Domain.ViewModels
{
    public class HeadersAndRows
    {               
        public List<string> DateHeaders { get; set; } 
                 
        public List<RowWithHour> RowsOfHour { get; set; }

        public HeadersAndRows()
        {
            this.RowsOfHour = new List<RowWithHour>();
        }
    }
}
