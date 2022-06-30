using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.Practice.Controllers
{
    public class TeachersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
