using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using codekriyaApp.Models;

namespace codekriyaApp.Controllers;

public class Events_Delegates_LambdasController : Controller
{
    public IActionResult Index()
    {
    return View();
    }
        
    public IActionResult Events_Event_Handlers_NET()
    {
    return View();
    }
    public IActionResult UserDefinedDelegates()
    {
    return View();
    }

    public IActionResult AnonymousMethods()
    {
    return View();
    }
    public IActionResult LambdaExpressions()
    {
    return View();
    }
    public IActionResult Linq()
    {
    return View();
    }
    public IActionResult ExpressionTrees()
    {
    return View();
    }
    public IActionResult AsynchronousCallbacks()
    {
    return View();
    }
}