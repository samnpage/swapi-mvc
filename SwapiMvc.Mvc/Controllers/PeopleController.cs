using Microsoft.AspNetCore.Mvc;

namespace SwapiMvc.Mvc.Controllers;

public class PeopleController : Controller
{
    private readonly HttpClient _httpClient;
    public PeopleController(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient("swapi");
    }
    public async Task<IActionResult> Index()
    {
        return View();
    }
}