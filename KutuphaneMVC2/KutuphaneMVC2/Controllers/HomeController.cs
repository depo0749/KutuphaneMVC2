using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using KutuphaneMVC2.Models;
using KutuphaneMVC2.Data;
using Microsoft.EntityFrameworkCore;

namespace KutuphaneMVC2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly KutuphaneContext _context;

    public HomeController(ILogger<HomeController> logger, KutuphaneContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        ViewBag.ToplamKitap = await _context.Kitaplar.CountAsync();
        ViewBag.ToplamKullanici = await _context.Kullanicilar.CountAsync();
        ViewBag.AktifOdunc = await _context.Oduncler.Where(o => !o.TeslimEdildi).CountAsync();

        return View();
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
