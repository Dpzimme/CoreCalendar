using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarE2.Domain.ViewModels
{
    public class EventVM  
    {
        public int id { get; set; }
        public string Title { get; set; }


        public string TitleThumbnail => this.Title.Length > 8 ? this.Title.Substring(0, 8) : this.Title;

        public string Description { get; set; }

        public string DescriptionThumbnail => this.Description.Length > 12 ? this.Description.Substring(0, 12) : this.Description;

        public CalendarUser User { get; set; }
        public int UserId { get; set; }
        public DateTime DateHour { get; set; }

        //   ???the Hour without AM / PM 
        public string DateT => this.DateHour.ToShortDateString();
      
        public int HourInt => this.DateHour.Hour;

        // Month and DateStr  -- remove trailing :00 
        //public string MoDayStr => DateHour.Month + DateStr;
        // last 2 characters, either AM or PM
        public string AMPM => this.DateHour.ToShortTimeString().Substring(DateHour.ToShortTimeString().Length - 3, 3).Trim();
        public EventVM()
        {
        }
        public EventVM(DateTime dT)
        {
            this.DateHour = dT;
        }            
    }
}
