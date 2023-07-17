using Kavenegar;
using Microsoft.AspNetCore.Mvc;
using Sample01.Models;
using System.Diagnostics;

namespace Sample01.Controllers
{
    public class ContactController : Controller
    {
        private readonly Context context;
        public ContactController(Context db)
        {
            context=db;
        }
        
        public IActionResult Index(){
            return View();
        }

        [HttpPost]
        public IActionResult SendCode(string phoneNumber)
        {
            Random rnd = new Random();
            string number = rnd.Next(1000,9999).ToString();

            var api = new KavenegarApi("3871353043697339486A70384F544A4A574C74612B51432F4C7A4B305076645457396F5267456F7A5A34383D");
             api.VerifyLookup(phoneNumber, number, "demo");

             User user=new User();
             user.PhoneNumber=phoneNumber;
             user.Code= number;
             context.Users.Add(user);
             context.SaveChanges();
             return RedirectToAction("Code");
        }
    }
}
