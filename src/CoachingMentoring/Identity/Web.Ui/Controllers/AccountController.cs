using Microsoft.AspNetCore.Mvc;

namespace AnishCeDev.CoachingMentoring.Identity.Web.Ui.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
