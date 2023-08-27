

using Microsoft.AspNetCore.Mvc;
namespace App.Admin.Controllers;

[Area("Admin")]
public class MenuController : Controller
{
     public IActionResult Index()
     { 
         return View();
     }
        
}