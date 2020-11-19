using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OpticEngine.Controllers
{
    [Authorize]
    public class ActivitiesController : Controller
    {
        public IActionResult Activities()
        {
            return View();
        }
    }
}