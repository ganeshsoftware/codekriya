using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using codekriyaApp.Models;

namespace codekriyaApp.Controllers;

public class Manipulating_FilesController : Controller
{
   
   public IActionResult Index()
   {
    return View();
   }
   public IActionResult FileSystemTypes()
    {
    return View();
    }

    public IActionResult FileManagement()
    {
    return View();
    }

    public IActionResult Filestreams()
    {
    return View();
    }

    public IActionResult Streamwriter_Streamreader()
    {
    return View();
    }

    public IActionResult Textwriter_Textreader()
    {
    return View();
    }

    public IActionResult Stringwriter_Stringreader()
    {
    return View();
    }

    public IActionResult DriveInfo_DirectoryInfo_FileInfo()
    {
    return View();
    }

    public IActionResult Reading_Writing_Data_Files()
    {
    return View();
    }

}