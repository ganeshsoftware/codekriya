using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using codekriyaApp.Models;


namespace codekriyaApp.Controllers;

public class Tasks_Threads_SynchronizationController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
    
    
    public IActionResult Multithreading_AnOverview()
    {
        return View();
    }

    public IActionResult TheThreadClass()
    {
        return View();
    }

    public IActionResult ThreadStates()
    {
        return View();
    }

    public IActionResult ThreadPools()
    {
        return View();
    }

    public IActionResult AsyncAwait()
    {
        return View();
    }

    public IActionResult Task_T()
    {
        return View();
    }
}