using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OpticEngine.Controllers
{
    [Authorize]
    public class PerformanceController : Controller
    {
        public IActionResult PerformanceIndicator()
        {
            return View();
        }

        public IActionResult PerformanceReview()
        {
            return View();
        }

        public IActionResult PerformanceAppraisal()
        {
            return View();
        }
    }
}