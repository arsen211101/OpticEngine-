using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OpticEngine.Controllers
{
    [Authorize]
    public class AuthenticationController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        public IActionResult OTP()
        {
            return View();
        }
        public IActionResult LockScreen()
        {
            return View();
        }
    }
}