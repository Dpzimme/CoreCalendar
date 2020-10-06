using CalendarE2.Data;
using CalendarE2.Data.Services;
using CalendarE2.Domain;
using CalendarE2.Domain.ViewModels;
using CalendarE2.WebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CalendarContext ctx;
        private readonly EventService eventService;

        //public HomeController(ILogger<HomeController> logger, CalendarContext _ctx, EventService _eventService)
        public HomeController(CalendarContext _ctx, EventService _eventService)
        {
            //this._logger = logger;
            this.ctx = _ctx;
            this.eventService = _eventService;
        }

        [AllowAnonymous]
        public IActionResult Index(int? theYr, int? theMo, int? theDay, string timeFrameStr)
        {
            DateTime theDayDT;
            if (theYr == null || theMo == null || theDay == null || theYr < 1900)
            {
                theDayDT = DateTime.Today;
            }
            else
            {
                theDayDT = new DateTime((int)theYr, (int)theMo, (int)theDay);
            }

            if (string.IsNullOrEmpty(timeFrameStr)) { timeFrameStr = "1"; }
            StartDayViewModel startDayViewModel = new StartDayViewModel(theDayDT, timeFrameStr);
            return View(startDayViewModel);
        }

        public IActionResult NewDay(int theYr, int theMo, int theDay)
        {
            DateTime theDayDT = new DateTime(theYr, theMo, theDay);
            return ViewComponent("DayOfInterest", new { yr = theYr, mo = theMo, day = theDay });
        }

        public IActionResult NewWeek(int theYr, int theMo, int theDay)
        {
            DateTime theDayDT = new DateTime(theYr, theMo, theDay);
            return ViewComponent("WeekOfInterest", new { yr = theYr, mo = theMo, day = theDay });
        }

        public IActionResult NewMonth(int theYr, int theMo, int theDay)
        {
            DateTime theDayDT = new DateTime(theYr, theMo, theDay);
            return ViewComponent("MonthOfInterest", new { yr = theYr, mo = theMo, day = theDay });
        }

        public IActionResult CreateOrUpdateEvent(string newTitle, string newDescription, int Yr, int Mo, int Dy, int Hour, string ModalTimeFrame)
        {

            DateTime HourDate = new DateTime(Yr, Mo, Dy, Hour, 0, 0);
            try
            {
                MyEvent foundEvent = ctx.Events.FirstOrDefault(ev => ev.DateHour == HourDate);
                if (foundEvent != null)
                {
                    foundEvent.Title = newTitle;
                    foundEvent.Description = newDescription;
                    ctx.Events.Update(foundEvent);
                    ctx.SaveChanges();
                }
                else
                {
                    ctx.Events.Add(new MyEvent() { Title = newTitle, Description = newDescription, DateHour = HourDate, UserId = 1 });
                    var createdRec = ctx.SaveChanges();

                }
                //return  to last visited page
                return RedirectToAction("Index", new { theYr = Yr, theMo = Mo, theDay = Dy, timeFrameStr = ModalTimeFrame });               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return PartialView("_error creating schedule");
            }
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
