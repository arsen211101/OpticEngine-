using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OpticEngine.Controllers
{
    [Authorize]
    public class ReportsController : Controller
    {
        public IActionResult ExpenseReport()
        {
            return View();
        }
        public IActionResult InvoiceReport()
        {
            return View();
        }
    }
}