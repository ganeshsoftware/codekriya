using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using codekriyaApp.Models;

namespace codekriyaApp.Controllers;

public class AssembliesController : Controller
{
    
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Private_Public_Satellite_Assemblies()
    {
    return View();
    }

    public IActionResult Assembly_Types()
    {
    return View();
    }

    public IActionResult Assembly_Linking()
    {
    return View();
    }

    public IActionResult StrongNaming()
    {
    return View();
    }

    public IActionResult GACUtil()
    {
    return View();
    }

    public IActionResult Delayed_Signing()
    {
    return View();
    }
}