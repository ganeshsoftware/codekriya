using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using codekriyaApp.Models;

namespace codekriyaApp.Controllers;

public class NETCore6CS:Controller
{
    public IActionResult Index()
    {
        return View();    
    }

    public IActionResult NetArchitecture()
    {
        return View();
    }

    public IActionResult GettingStartedWithCS6() 
    {
        return View();
    }
}