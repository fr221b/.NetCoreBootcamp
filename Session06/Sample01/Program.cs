using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test the program
            Dictionary<int, string> products = new Dictionary<int, string>();
            Product product = new Product(products);
            product.AddProduct(1,"A");
            Console.WriteLine(product.Products[1]);
            //Console.WriteLine(product.Products.Count);
            product.GetAll();
            product.GetProductById(1);
            product.RemoveProduct(1);
            product.GetAll();
            product.AddProduct(1, "A");
            product.AddProduct(1, "A");
            product.AddProduct(2, "B");
            product.RemoveProduct(1);
            product.RemoveProduct(2);
            product.AddProduct(1, "A");
            product.AddProduct(1, "A");
            product.AddProduct(2, "B");
            product.GetAll();
            product.UpdateProduct(1, "C");
            product.GetAll();
            Console.ReadLine();
        }
    }
}
