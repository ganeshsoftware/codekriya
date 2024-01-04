using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using codekriyaApp.Models;

namespace codekriyaApp.Controllers;

public class Memory_Management_PointersController : Controller
{
    public IActionResult Index()
    {
        return View();    
    }
    public IActionResult Theory_ManagedHeap()
    {
        return View();
    }
    public IActionResult Unmanaged_Resources()
    {
        return View();
    }
    public IActionResult Garbage_Collector()
    {
        return View();
    }
    public IActionResult FreeingManagedAndUnmanagedResources()
    {
        return View();
    }
    public IActionResult Weak_Strong_References()
    {
        return View();
    }
    public IActionResult Generations()
    {
        return View();
    }
    public IActionResult IDisposable()
    {
        return View();
    }
    public IActionResult Dispose_Finalize()
    {
        return View();
    }
    public IActionResult Pointers_NET()
    {
        return View();
    }
}