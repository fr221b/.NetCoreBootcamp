using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01
{
    public interface IOrder
    {
        decimal GetPrice(int numbers, int ProductCode);
    }
}
