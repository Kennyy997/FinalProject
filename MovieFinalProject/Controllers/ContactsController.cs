using Microsoft.AspNetCore.Mvc;

namespace MovieFinalProject.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
