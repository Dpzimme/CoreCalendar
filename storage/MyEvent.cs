using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalendarE2.Domain
{
    public class MyEvent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string Title {
            get => this.Title;
            set {
                this.Title = value;                
            }
        }

        //public string TitleThumbnail  {get => this.Title.Substring(0, 8); } 
        public string TitleThumbnail;
        public string Description { get; set; }
        
        public CalendarUser User { get; set; }
        public int UserId { get; set; }                            
        public DateTime DateHour { get; set; }        

        //   ???the Hour without AM / PM 
        public string DateStr => DateHour.ToShortTimeString().Substring(0, DateHour.ToShortTimeString().Length - 3);       

        // Month and DateStr  -- remove trailing :00 
        public string MoDayStr => DateHour.Month + DateStr;
        // last 2 characters, either AM or PM
        public string AMPM => DateHour.ToShortTimeString().Substring(DateHour.ToShortTimeString().Length - 3, 2);

        //public string DisplayHour => DateHour.Hour < 12 ? DateHour.Hour.ToString()  : (DateHour.Hour - 12).ToString();
       
        public MyEvent()
        {            
        }
        
        public bool IsValid(int yr, int mo, int day, int hr, string _title, string _description)
        {
            // check mo, day hr             
            if (mo > 12 || hr > 24 || day > DaysInMo(yr, mo))
            {
                return false;
            }
            return true;
        }

        private int DaysInMo(int yr, int mo)
        {
            int[] daysInMo = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            bool isLeapYr = yr % 4 == 0 ? true : false;
            if (isLeapYr) { daysInMo[1] = 29; }
            return daysInMo[mo];
        }
    }
}
