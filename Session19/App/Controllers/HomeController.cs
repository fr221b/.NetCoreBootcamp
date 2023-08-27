using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using App.Models;
using Core.Interface;

namespace App.Controllers;

public class HomeController : Controller
{
    private readonly IMenu imenu;
    public HomeController(IMenu _imenu)
    {
        imenu=_imenu;
    }
    public IActionResult Index()
    {
        ViewBag.Menu=imenu.GetAllMenus().OrderBy(x => x.Id);
        return View();
    }

}
