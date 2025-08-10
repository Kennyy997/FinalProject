using Microsoft.AspNetCore.Mvc;

namespace MovieFinalProject.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
