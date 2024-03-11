using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aspHeidi.Models.Entities;

namespace aspHeidi.Controllers;

public class HomeController : Controller
{
    
    private readonly kitapdbContext dbContext = new kitapdbContext();

    public HomeController(kitapdbContext _dbContext)
    {
        dbContext = _dbContext; 
    }

    public IActionResult Index()
    {
        var Turler = dbContext.Turlers.ToList();
        return View(Turler);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    
}
