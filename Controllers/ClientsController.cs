using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OpticEngine.Controllers
{
    [Authorize]
    public class ClientsController : Controller
    {
        public IActionResult Clients()
        {
            return View();
        }
    }
}