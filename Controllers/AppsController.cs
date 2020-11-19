using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OpticEngine.Controllers
{
    [Authorize]
    public class AppsController : Controller
    {
        public IActionResult Chats()
        {
            return View();
        }
        
        public IActionResult Calendar()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult Email()
        {
            return View();
        }
        public IActionResult FileManager()
        {
            return View();
        }

        #region Apps/Calls
        public IActionResult VoiceCall()
        {
            return View();
        }

        public IActionResult VideoCall()
        {
            return View();
        }

        public IActionResult OutgoingCall()
        {
            return View();
        }

        public IActionResult IncomingCall()
        {
            return View();
        }
        #endregion
    }
}