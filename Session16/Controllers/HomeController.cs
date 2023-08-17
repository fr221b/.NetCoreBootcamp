using System.Diagnostics;
using CQRS.Product.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Session16.Models;

namespace Session16.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IMediator mediatr;

    public HomeController(IMediator _mediatr)
    {
        mediatr=_mediatr;    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public  IActionResult AddProduct(SaveProductCommand saveProductCommand)
    {
        var result= mediatr.Send(saveProductCommand);
        return RedirectToAction("Index");
    }
    
}
