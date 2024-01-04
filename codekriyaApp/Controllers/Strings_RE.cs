using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using codekriyaApp.Models;

namespace codekriyaApp.Controllers;

public class Strings_REController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult CSharpStrings()
    {
        return View();
    }

    public IActionResult StringImmutability() 
    {
        return View();
    }

    public IActionResult CommonlyStringMethods()
    {
        return View();
    }

    public IActionResult RegularExpressions()
    {
        return View();
    }

    public IActionResult CustomRE()
    {
        return View();
    }
}