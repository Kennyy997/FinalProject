using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MovieFinalProject.DataContext;
namespace MovieFinalProject.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;
    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }
    [HttpGet]
    public JsonResult Search(string query)
    {
        if (string.IsNullOrWhiteSpace(query))
            return Json(new List<object>());

        var movies = _context.Movies
            .Where(m => m.Title.Contains(query))
            .Select(m => new
            {
                m.Id,
                m.Title,
                m.PosterUrl
            })
            .ToList();

        return Json(movies);
    }
}
