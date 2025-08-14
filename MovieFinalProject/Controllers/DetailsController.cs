using Microsoft.AspNetCore.Mvc;

namespace MovieFinalProject.Controllers
{
    public class DetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Review()
        {
            return View();
        }

    }
}
