using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OpticEngine.Controllers
{
    [Authorize]
    public class TrainingController : Controller
    {
        public IActionResult TrainingList()
        {
            return View();
        }
        public IActionResult Trainers()
        {
            return View();
        }
        public IActionResult TrainingType()
        {
            return View();
        }

    }
}