using CalendarE2.Data.Services;
using CalendarE2.Domain.ViewModels;
using CalendarE2.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CalendarE2.WebApp.Views.Home.Components
{
    public class WeekOfInterest : ViewComponent
    {
        private EventService eventService;
        public WeekOfInterest(EventService _eventService)
        {
            this.eventService = _eventService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int yr, int mo, int day)
        {
            DateTime choosenDate = new DateTime(yr, mo, day, 0, 0, 0);
            DateTime startDate = GetStartOfPeriod.getStartDateOfWeek(choosenDate);
            PeriodViewModel pViewModel = new PeriodViewModel(startDate, 2);
            pViewModel.Schedule = eventService.GetSchedule(startDate, 7);
            return View(pViewModel);
        }

    }
}
