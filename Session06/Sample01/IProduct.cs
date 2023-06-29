using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01
{
    public interface IProduct
    { 
        #region [- Behaviors -]
        void AddProduct( int productId, string productName);
        void RemoveProduct(int prodcutId);
        void UpdateProduct(int productId, string productName);
        void GetProductById(int productId);
        void GetAll(); 
        #endregion

    }
}
