using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01
{
    public class OrderDetail 
    {
        #region [- Ctor -]
        public OrderDetail(List<Product> products)
        {

        } 
        #endregion
        public decimal GetPrice(int numbers, int ProductCode)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
