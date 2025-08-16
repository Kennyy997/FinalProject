using Microsoft.AspNetCore.Mvc;
using MovieFinalProject.DataContext.Entities;
using MovieFinalProject.DataAccessLayer;

namespace MovieFinalProject.Controllers
{
    public class ReviewController : Controller
    {
        private readonly AppDbContext _context;

        public ReviewController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Add(Review review)
        {
            review.CreatedAt = DateTime.Now;
            _context.Reviews.Add(review);
            _context.SaveChanges();

            return RedirectToAction("Details", "Movie", new { id = review.MovieId });
        }
    }
}
