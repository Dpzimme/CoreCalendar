using CalendarE2.Data.Services;
using CalendarE2.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CalendarE2.WebApp.Views.Home.Components
{
    public class DayOfInterest : ViewComponent
    {
        private EventService eventService;
        public DayOfInterest(EventService _eventService)
        {
            this.eventService = _eventService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int yr, int mo, int day)
        {
            DateTime choosenDate = new DateTime(yr, mo, day, 0, 0, 0);
            PeriodViewModel pViewModel = new PeriodViewModel(choosenDate, 1);
            pViewModel.Schedule = eventService.GetSchedule(choosenDate, 1);
            return View(pViewModel);
        }

    }
}
