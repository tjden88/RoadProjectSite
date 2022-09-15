using Microsoft.AspNetCore.Mvc;

namespace RoadProjectSite.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
