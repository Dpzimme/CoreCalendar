using CalendarE2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalendarE2.Infrastructure;
using CalendarE2.Domain.ViewModels;
using AutoMapper;

namespace CalendarE2.Data.Services
{
    public class EventService
    {
        // Service Pattern. use Entity Framework as Repository layer because there are no repeated calls to EF, just this one call. 
        // Another layer of abstraction is not warranted.  
        // Could add calls to the user repo with later revisions.
        private CalendarContext ctx;
       
        public int numbDays { get; set; }

        public List<EventVM> Schedule { get; set; }
       
        public EventService(CalendarContext _ctx)
        {
            this.ctx = _ctx;
        }        

        public List<RowWithHour> GetSchedule(DateTime dT, int numbDays)       
        {            
            List<MyEvent> eventsOfPeriod = ctx.Events
                .Where(e => e.DateHour.Day >= dT.Day && e.DateHour.Day < dT.AddDays(numbDays).Day)
                .ToList();            
            List<EventVM> eventsVM = eventsOfPeriod
                .Select(e => new EventVM() { DateHour = e.DateHour, Title = e.Title, Description = e.Description })
                .OrderBy(ev => ev.HourInt)
                .ThenBy(ev => ev.DateHour.Year)
                .ThenBy(ev => ev.DateHour.Month)
                .ThenBy(ev => ev.DateHour.Day)
                .ToList();                          
            int eventsIndex = 0;
            int numbEvents = eventsOfPeriod.Count;
            // create list of rows as a list that can be used for the view  
            //By hour - each sub list will be the events with the same hour, then by day
            List<RowWithHour> PeriodSchedule = new List<RowWithHour>();
            for (int i = 6; i < 20; i++)   // start at 6am, go to 8pm 
            {
                List<EventVM> HourList = new List<EventVM>();
                for(int j = 0; j < numbDays; j++)
                {                    
                    DateTime dTLoopDay = dT.AddDays(j);
                    DateTime newDT = new DateTime(dTLoopDay.Year, dTLoopDay.Month, dTLoopDay.Day, i, 0, 0);
                    // checks if the event from database matches the the time of the double loop, don't need to worry about year
                    if (eventsIndex < numbEvents)
                    {                       
                        
                        EventVM eventOfLoop = eventsVM[eventsIndex];
                        if (dTLoopDay.Year == eventOfLoop.DateHour.Year &&  dTLoopDay.Day == eventOfLoop.DateHour.Day && eventOfLoop.HourInt == i)
                        {
                            HourList.Add(eventOfLoop);
                            eventsIndex++;
                        }
                        else
                        {
                            // Use a blank event for the time slot, as the current event doesn't match the time                            
                            EventVM newEventVM = new EventVM(newDT);
                            newEventVM.Title = "  ";
                            newEventVM.Description = "  ";
                            HourList.Add(newEventVM);
                        }
                    }
                    else
                    {
                        EventVM newEventVM = new EventVM(newDT);
                        newEventVM.Title = "  ";
                        newEventVM.Description = " ";                                            
                        HourList.Add(newEventVM);
                    }                    
                }
                RowWithHour loopRWH = new RowWithHour(i, HourList);
                PeriodSchedule.Add(loopRWH);
            }            
            return PeriodSchedule;
        }       
    }
}
