using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OpticEngine.Controllers
{
    [Authorize]
    public class JobsController : Controller
    {
        public IActionResult ManageJobs()
        {
            return View();
        }

        public IActionResult AppliedCandidates()
        {
            return View();
        }
    }
}