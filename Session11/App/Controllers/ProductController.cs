using Core.Domain.User;
using Core.Interface.Product;
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
         
         
}