using Microsoft.AspNetCore.Mvc;

namespace RoadProjectSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
