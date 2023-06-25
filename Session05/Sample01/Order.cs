using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01
{
    public class Order : IOrder
    {
        public decimal GetPrice(int numbers, int ProductCode)
        {
            throw new NotImplementedException();
        }
    }
}
