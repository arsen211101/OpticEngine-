using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OpticEngine.Controllers
{
    [Authorize]
    public class TicketsController : Controller
    {
        public IActionResult Tickets()
        {
            return View();
        }
    }
}