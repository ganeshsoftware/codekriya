using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using codekriyaApp.Models;

namespace codekriyaApp.Controllers;

public class Collection_BuiltInInterfacesController : Controller
{

    public IActionResult Index()
    {
    return View();
    }

    public IActionResult IEnumerable_T()
    {
    return View();
    }

    public IActionResult IEnumerator_T()
    {
    return View();
    }

    public IActionResult ICollection_T()
    {
    return View();
    }

    public IActionResult IList_T()
    {
    return View();
    }

    public IActionResult IQueryable_T()
    {
    return View();
    }

    public IActionResult IDictionary()
    {
    return View();
    }
}