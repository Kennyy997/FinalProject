using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieFinalProject.DataAccessLayer;

namespace MovieFinalProject.Controllers
{
    public class MovieController : Controller
    {
        private readonly AppDbContext _context;
        public MovieController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            // This action could be used to display a list of movies
            return View();
        }
        public IActionResult Details(int id)
        {
            var movie = _context.Movies
                .Include(m => m.Reviews)
                .FirstOrDefault(m => m.Id == id);

            if (movie == null) return NotFound();

            return View(movie);
        }
        public IActionResult Search(string query)
        {
            // This action could be used to search for movies based on a query string
            return View(query);
        }
    }
}
