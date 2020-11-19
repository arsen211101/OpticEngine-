using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OpticEngine.Controllers
{
    [Authorize]
    public class PayrollController : Controller
    {
        public IActionResult EmployeeSalary()
        {
            return View();
        }
        public IActionResult Payslip()
        {
            return View();
        }
        public IActionResult PayrollItems()
        {
            return View();
        }
    }
}