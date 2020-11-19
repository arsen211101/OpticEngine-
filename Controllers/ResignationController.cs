using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OpticEngine.Controllers
{
    [Authorize]
    public class ResignationController : Controller
    {
        public IActionResult Resignation()
        {
            return View();
        }
    }
}