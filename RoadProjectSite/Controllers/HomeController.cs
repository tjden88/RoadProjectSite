using Microsoft.AspNetCore.Mvc;

namespace RoadProjectSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Error/{Code}")]
        public IActionResult Error(int Code)
        {
            if (Code == 404)
            {
                return View("NotFoundPage");
            }

            return StatusCode(Code);
        }

        public IActionResult SiteNotAvaliable() => View();

        public IActionResult About() => View();
    }
}
