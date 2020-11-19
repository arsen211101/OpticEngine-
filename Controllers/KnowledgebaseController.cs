using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OpticEngine.Controllers
{
    [Authorize]
    public class KnowledgebaseController : Controller
    {
        public IActionResult Knowledgebase()
        {
            return View();
        }
    }
}