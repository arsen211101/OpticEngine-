using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OpticEngine.Controllers
{
    [Authorize]
    public class TerminationController : Controller
    {
        public IActionResult Termination()
        {
            return View();
        }
    }
}