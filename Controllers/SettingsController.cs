using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OpticEngine.Controllers
{
    [Authorize]
    public class SettingsController : Controller
    {
        public IActionResult Settings()
        {
            return View();
        }
    }
}