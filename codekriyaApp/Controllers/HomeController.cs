using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using codekriyaApp.Models;


namespace codekriyaApp.Controllers;

public class HomeController : Controller
{
   // private readonly ILogger<HomeController> _logger;
/*
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
*/
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Microsoft_Dotnet_with_Csharp()
    {
        return View();
    }

    public IActionResult Creating_WebApps_Applications_With_ASPNET()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
/*
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
*/
}
