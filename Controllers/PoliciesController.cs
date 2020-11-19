using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OpticEngine.Controllers
{
    [Authorize]
    public class PoliciesController : Controller
    {
        public IActionResult Policies()
        {
            return View();
        }
    }
}