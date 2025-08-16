using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieFinalProject.DataAccessLayer;

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
    .Include(m => m.Genres)
    .ToList();
        return View(model);
    }
    public IActionResult Privacy()
    {
        return View();
    }
 

}
