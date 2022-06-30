using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.Practice.Controllers
{
    public class BlogController:Controller
    {




        public IActionResult Index()
        {
            return View();
        }
    }
}
