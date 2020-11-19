using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OpticEngine.Controllers
{
    [Authorize]
    public class PagesController : Controller
    {
        public IActionResult Search()
        {
            return View();
        }
        public IActionResult FAQ()
        {
            return View();
        }
        public IActionResult Terms()
        {
            return View();
        }
        public IActionResult PrivacyPolicy()
        {
            return View();
        }
        public IActionResult BlankPage()
        {
            return View();
        }
    }
}