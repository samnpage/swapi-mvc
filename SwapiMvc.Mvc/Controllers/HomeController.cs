using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SwapiMvc.Models;

namespace SwapiMvc.Mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private static Random _random = new Random();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
        string [] names = new[] { "Autumn", "Alecx", "Tom", "Kenn", "Paul"};
        string name = names[_random.Next(0, names.Length)];
        return View(model: name);
    }

    public async Task<IActionResult> Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
