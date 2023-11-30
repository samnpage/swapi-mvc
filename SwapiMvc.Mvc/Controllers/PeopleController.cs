using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using SwapiMvc.Models;

namespace SwapiMvc.Mvc.Controllers;

public class PeopleController : Controller
{
    private readonly HttpClient _httpClient;
    public PeopleController(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient("swapi");
    }
    public async Task<IActionResult> Index(string page)
    {
        string route = $"people?page={page ?? "1"}";
        HttpResponseMessage response = await _httpClient.GetAsync(route);

        var responseString = await response.Content.ReadAsStringAsync();
        var people = JsonSerializer.Deserialize<ResultsViewModel<PeopleViewModel>>(responseString);

        return View(people);
    }
}