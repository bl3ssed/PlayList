using System;
using Microsoft.AspNetCore.Mvc;
using PlayList.Models;
using System.Diagnostics;
/// <summary>
/// Summary description for Class1
/// </summary>
public class ProjectsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}