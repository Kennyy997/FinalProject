using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieFinalProject.DataAccessLayer;
using MovieFinalProject.ViewModel;

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
        var movies = _context.Movies.ToList();

        var viewModel = new HomeViewModel
        {
            Movies = movies,
            Genres = _context.Genres.ToList(),
            Ratings = _context.Ratings.ToList(),
            Actors = _context.Actors.ToList(),
            Qualities = _context.Qualitys.ToList(),
        };

        return View(viewModel);
    }
    public IActionResult Privacy()
    {
        return View();
    }
 

}
