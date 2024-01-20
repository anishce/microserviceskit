using Microsoft.AspNetCore.Mvc;

namespace AnishCeDev.CoachingMentoring.Identity.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
