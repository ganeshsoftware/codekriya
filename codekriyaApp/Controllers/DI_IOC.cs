
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using codekriyaApp.Models;


namespace codekriyaApp.Controllers;

public class DI_IOCController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Introduction()
    {
        return View();
    }
    public IActionResult Dependency_Injection()
    {
        return View();
    }
    public IActionResult Inversion_Control_Principle()
    {
        return View();
    }
    public IActionResult Dependency_Inversion_Principle()
    {
        return View();
    }
    public IActionResult IoC_Container()
    {
        return View();
    }
}