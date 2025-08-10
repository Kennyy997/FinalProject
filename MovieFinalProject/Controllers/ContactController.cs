using Microsoft.AspNetCore.Mvc;

namespace MovieFinalProject.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SendMessage()
        {
            // Logic to handle sending a message
            // This could involve saving the message to a database or sending an email

            // For now, we'll just return a view indicating success
            return View("MessageSent");
        }
    }
}
