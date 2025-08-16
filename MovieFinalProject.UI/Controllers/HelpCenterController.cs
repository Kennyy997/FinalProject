using Microsoft.AspNetCore.Mvc;

namespace MovieFinalProject.Controllers
{
    public class HelpCenterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
