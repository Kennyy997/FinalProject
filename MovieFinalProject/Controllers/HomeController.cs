using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        var model = _context.Movies
    .Include(m => m.MovieGenres)
    .ThenInclude(mg => mg.Genre)
    .ToList();
        return View(model);
    }
    public IActionResult Privacy()
    {
        return View();
    }
 

}
