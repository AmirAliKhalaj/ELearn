using Microsoft.AspNetCore.Mvc;

namespace ELearn.Areas.Admin
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()             
        {
            return View();
        }
    }
}
