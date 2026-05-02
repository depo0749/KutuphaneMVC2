using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using KutuphaneMVC2.Models;

namespace KutuphaneMVC2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IKutuphaneMVC2 _kutuphaneMVC2;

    public HomeController(ILogger<HomeController> logger, KutuphaneMVC2 kutuphaneMVC2)
    {
        _logger = logger;
        _kutuphaneMVC2 = kutuphaneMVC2;
    }

    public IActionResult Index()
    {
        return View(KutuphaneMVC2);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
