using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OpticEngine.Controllers
{
    [Authorize]
    public class AssetsController : Controller
    {
        public IActionResult Assets()
        {
            return View();
        }
    }
}