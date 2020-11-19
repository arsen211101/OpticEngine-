using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OpticEngine.Controllers
{

    [Authorize]
    public class AccountsController : Controller
    {
        public IActionResult Estimates()
        {
            return View();
        }

        public IActionResult Invoices()
        {
            return View();
        }
        public IActionResult Payments()
        {
            return View();
        }
        public IActionResult Expenses()
        {
            return View();
        }
        public IActionResult ProvidentFund()
        {
            return View();
        }
        public IActionResult Taxes()
        {
            return View();
        }
    }
}