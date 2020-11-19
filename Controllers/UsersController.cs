using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OpticEngine.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {
        public IActionResult Users()
        {
            return View();
        }
    }
}