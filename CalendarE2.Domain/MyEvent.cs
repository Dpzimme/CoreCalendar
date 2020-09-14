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
        public string Title { get; set; }              
        public string Description { get; set; }
        
        public CalendarUser User { get; set; }
        public int UserId { get; set; }                            
        public DateTime DateHour { get; set; }       
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
