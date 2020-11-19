using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OpticEngine.Controllers
{
    [Authorize]
    public class GoalsController : Controller
    {
        public IActionResult GoalList()
        {
            return View();
        }
        
        public IActionResult GoalType()
        {
            return View();
        }
    }
}