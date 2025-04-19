using Microsoft.AspNetCore.Mvc;

namespace ELearn.Areas.Admin.Controllers
{
    public class CourseSeasonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
