using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OpticEngine.Controllers
{
    [Authorize]
    public class SubscriptionsController : Controller
    {
        public IActionResult SubscriptionsAdmin()
        {
            return View();
        }
        public IActionResult SubscriptionsCompany()
        {
            return View();
        }
        public IActionResult SubscribedCompanies()
        {
            return View();
        }
    }
}