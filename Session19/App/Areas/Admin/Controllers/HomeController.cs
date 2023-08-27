using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Core.Domain.Menu;
using Core.Interface;
using App.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace App.Admin.Controllers;
[Area("Admin")]
public class HomeController : Controller
{
     private readonly IMenu imenu;
     public HomeController(IMenu _imenu)
     {
        imenu=_imenu;
     }
    public IActionResult Index()
    {
        ViewBag.Menu=new SelectList(imenu.GetAllMenus(),"Id","CatName");
        var model=new List<ModelMenu>();
        foreach (var item in imenu.GetAllMenus())
        {
            item.ParentName=imenu.GetParentNameById(item.ParentId);
            model.Add(item);
        }
        ViewBag.Table=model;
        
        return View();
    }
     
     [HttpPost]
    public IActionResult Add(string CatName,string ParentId)
    {
        var modelMenu=new ModelMenu(){
              CatName=CatName,
              ParentId=int.Parse(ParentId),
              Status=true
        };
        imenu.Add(modelMenu);
        return RedirectToAction("Index");
    }
    
}
