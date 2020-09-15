using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CalendarE2.WebApp.Components
{
    public class AddUpdateModal : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
