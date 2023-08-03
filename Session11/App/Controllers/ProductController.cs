using Core.Domain.User;
using Core.Interface.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

public class ProductController : Controller
{
    private readonly IProduct iproduct;
    public ProductController(IProduct _iproduct)
    {
        iproduct=_iproduct;
    }
         public IActionResult Index()
         {
            ViewBag.basket = HttpContext.Session.GetString("id");
            ViewBag.list=iproduct.GetAllProduct();
             return View();
         }
         
         public IActionResult AddProduct(MProduct product)
         {
            iproduct.AddProduct(product);
             return RedirectToAction("Index");
         }
         
         public IActionResult Delete(int id)
         {
             iproduct.DeleteProduct(id);
             return RedirectToAction("Index");
         }

         public IActionResult Edit(int id)
         {
            var product=iproduct.GetProductById(id);
             return View(product);
         }

         public IActionResult UpdateProduct(MProduct mProduct)
         {
            iproduct.UpdateProduct(mProduct);
             return RedirectToAction("Index");
         }
         
         public IActionResult AddBasket(int id)
         {
            var basket=HttpContext.Session.GetString("id");

            if(basket != null)
            {
                 basket += "," + id;
            }
            else
            {
                 basket = id.ToString();
            }

            HttpContext.Session.SetString("id",basket);
            
             return RedirectToAction("Index");

         }

         public IActionResult ShowBasket()
         {
            var basket = HttpContext.Session.GetString("id");
            string[] basketArray = basket.Split(',');
            string[] distinctArray=basketArray.Distinct().ToArray();
            int[] IntArray=Array.ConvertAll(basketArray,int.Parse);
            int[] distinctIntArray=Array.ConvertAll(distinctArray,int.Parse);
            var dict = new Dictionary<int, int>();
            foreach (var value in IntArray)
            {
                dict.TryGetValue(value, out int count);
                dict[value] = count + 1;
            }
            ViewBag.Products=iproduct.GetProductInRange(distinctIntArray);
            ViewBag.ProductsQuantity=dict.Values.ToList();
            
            return View();
         }
         
         
         
         
         
         
         
}