using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using codekriyaApp.Models;


namespace codekriyaApp.Controllers;

public class Errors_ExceptionsController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
   
    public IActionResult Errors_Exceptions()
    {
        return View();
    }
        
    public IActionResult Diff_Errors_Exception()
    {
        return View();
    }
    public IActionResult Builtin_Exceptions()
    {
        return View();
    }
    public IActionResult Exception_Hierarchy()
    {
        return View();
    }
    public IActionResult Try_catch_finally()
    {
        return View();
    }
    public IActionResult Throw_Keyword()
    {
        return View();
    }
    public IActionResult CustomException()
    {
        return View();
    }
}