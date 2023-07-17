using Kavenegar;
using Microsoft.AspNetCore.Mvc;
using MVCSample01.Models;

namespace MVCSample01.Controllers
{
    public class LoginController : Controller
    {
       private readonly Context? _context;
       public static string Phone;

       public LoginController(Context context)
       {
          _context=context;
       }

        public IActionResult Index(string phone)
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendCode(string phone)
        {
            Random rnd=new Random();
            string number=rnd.Next(1000, 9999).ToString();

            var api = new KavenegarApi("3871353043697339486A70384F544A4A574C74612B51432F4C7A4B305076645457396F5267456F7A5A34383D");
            api.VerifyLookup(phone, number,"demo");

            User user=new User();
            user.Phone=phone;
            user.Code=number;
            _context.Users.Add(user);
            _context.SaveChanges();
            
            Phone=phone;
            return RedirectToAction("Code");
        }

        public IActionResult Code(){
            return View();
        }

        public IActionResult Check(string code){

            var user=_context.Users.Where(u =>u.Code==code && u.Phone==Phone).FirstOrDefault();

            if(user!=null){
                 return RedirectToAction("Index","Home");
            }
            else
            {
                  return RedirectToAction("Code");
            }

            return View();
        }
    }
}
