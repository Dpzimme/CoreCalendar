using CalendarE2.Data.Services;
using CalendarE2.Domain.ViewModels;
using CalendarE2.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarE2.WebApp.Views.Home.Components
{
    public class PeriodOfInterest : ViewComponent
    {
        private EventService eventService;
        public PeriodOfInterest(EventService _eventService)
        {
            this.eventService = _eventService;
        }       
        public async Task<IViewComponentResult> InvokeAsync(int yr, int mo, int day, int numbDays)
        {
            DateTime choosenDate = new DateTime(yr, mo, day, 0, 0, 0);
            PeriodViewModel pViewModel = new PeriodViewModel(choosenDate);           
            DateTime startOfWeek = GetStartOfPeriod.getStartDateOfWeek(choosenDate);
            pViewModel.Schedule = eventService.GetSchedule(startOfWeek, 7);
            return View(pViewModel);
        }

    }
}
