using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Session17.Models;
using Session17.Models.Context;

namespace Session17.Controllers;

public class HomeController : Controller
{
    private readonly Context _context;
    public HomeController(Context context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult AccessDenied()
    {
        
        return View();
    }
    
    public IActionResult Login()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Check(string username,string password)
    {
        
        var user = _context.Users.Where(x => x.Username == username && x.Password == password).FirstOrDefault();

        if(username== user.Username && password==user.Password)
        {
            
            var claims=new List<Claim>
            {
                new Claim(ClaimTypes.Name,username),
                //new Claim(ClaimTypes.Role,"Admin"),
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString())
            };

            var identity=new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
            var principal=new ClaimsPrincipal(identity);
            HttpContext.SignInAsync(principal);
             return RedirectToAction("Index","Home",new {area = "Admin"});
        }
        else
        {
            return RedirectToAction("Login");
        }
        
    }
    
    
}
