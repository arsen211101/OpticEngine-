using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OpticEngine.Controllers
{
    [Authorize]
    public class LeadsController : Controller
    {
        public IActionResult Leads()
        {
            return View();
        }
    }
}