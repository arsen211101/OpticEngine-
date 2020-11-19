using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OpticEngine.Controllers
{
    [Authorize]
    public class PromotionController : Controller
    {
        public IActionResult Promotion()
        {
            return View();
        }
    }
}