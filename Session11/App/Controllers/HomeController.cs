using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using App.Models;
using Core.Domain.User;

namespace App.Controllers;

public class HomeController : Controller
{
    private readonly IUser _user;
    public HomeController(IUser iuser)
    {
        _user=iuser;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult SendSms(string Phone){
        
         _user.SendSms(Phone);

        return RedirectToAction("Index");
    }

    
}
