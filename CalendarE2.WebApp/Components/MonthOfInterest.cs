using CalendarE2.Data.Services;
using CalendarE2.Domain.ViewModels;
using CalendarE2.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CalendarE2.WebApp.Views.Home.Components
{
    public class MonthOfInterest : ViewComponent
    {
        private EventService eventService;
        public MonthOfInterest(EventService _eventService)
        {
            this.eventService = _eventService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int yr, int mo, int day)
        {
            DateTime choosenDate = new DateTime(yr, mo, day, 0, 0, 0);
            PeriodViewModel pViewModel = new PeriodViewModel(choosenDate, 3);
            pViewModel.Schedule = eventService.GetSchedule(choosenDate, NoDaysInMonth.GetNoDays(yr, mo));
            return View(pViewModel);
        }

    }
}
