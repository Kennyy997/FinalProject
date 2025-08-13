using Microsoft.AspNetCore.Mvc;

namespace MovieFinalProject.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HandleError(int statusCode)
        {
            if (statusCode == 404)
            {
                return View(); 
            }
            return View("Error"); 
        }
    }
}
