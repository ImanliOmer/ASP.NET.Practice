using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.Practice.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
