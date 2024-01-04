using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using codekriyaApp.Models;


namespace codekriyaApp.Controllers;


public class ADONET_Entity_FrameworkController:Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Object_Relational_Mapping()
    {
        return View();
    }

    public IActionResult EFRelationships()
    {
        return View();
    }

    public IActionResult DBContext()
    {
        return View();
    }

    public IActionResult Reading_Writing_Data_To_DB()
    {
        return View();
    }
}