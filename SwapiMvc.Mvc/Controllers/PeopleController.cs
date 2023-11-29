using Microsoft.AspNetCore.Mvc;

namespace SwapiMvc.Mvc.Controllers;

public class PeopleController : Controller
{
    public async Task<IActionResult> Index()
    {
        return View();
    }
}