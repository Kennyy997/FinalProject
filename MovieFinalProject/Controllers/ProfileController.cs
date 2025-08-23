using Microsoft.AspNetCore.Mvc;

namespace MovieFinalProject.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Comments()
        {
            return View();
        }
    } 

}
