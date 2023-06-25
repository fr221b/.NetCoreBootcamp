using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01
{
    public class Product
    {
        #region [- Props -]
        public string ProductName { get; set; }
        public int ProductCode { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string ImageUrl { get; set; } 
        #endregion

    }
}
