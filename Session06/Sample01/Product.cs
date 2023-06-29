using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01
{
    public class Product : IProduct
    {
        #region [- Ctor -]
        public Product(Dictionary<int, string> products)
        {
            Products = products;
        }
        #endregion

        #region [- Props -]
        public Dictionary<int, string> Products { get; set; } 
        #endregion

        #region [- AddProduct(int productId, string productName) -]
        public void AddProduct(int productId, string productName)
        {
            if (!Products.ContainsKey(productId))
            {
                Products.Add(productId, productName);
            }
            else
            {
                Console.WriteLine("This product is already exists.");
            }
        } 
        #endregion

        #region [- GetAll() -]
        public void GetAll()
        {
            foreach (var product in Products)
            {
                Console.WriteLine(product.Key +" "+product.Value);
            }
        }
        #endregion

        #region [- GetProductById(int productId) -]
        public void GetProductById(int productId)
        {
            Console.WriteLine(Products[productId]);
        }
        #endregion

        #region [- RemoveProduct(int prodcutId) -]
        public void RemoveProduct(int prodcutId)
        {
            Products.Remove(prodcutId);
        }
        #endregion

        #region [- UpdateProduct(int productId, string productName) -]
        public void UpdateProduct(int productId, string productName)
        {
            if (Products.TryGetValue(productId,out string name))
            {
                Products[productId] = productName;
            }
            else
            {
                Products.Add(productId,productName);
            }
        } 
        #endregion
    }
}
