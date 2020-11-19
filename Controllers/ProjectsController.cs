using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OpticEngine.Controllers
{
    [Authorize]
    public class ProjectsController : Controller
    {
        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult Tasks()
        {
            return View();
        }

        public IActionResult TaskBoard()
        {
            return View();
        }

    }
}