using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.Practice.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
