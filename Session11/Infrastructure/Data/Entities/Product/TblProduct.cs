using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Data.Entities.Product;

public class TblProduct
{
      [Key]
      public int ProductID { get; set;}
      public string ProductName { get; set; }
      public string Category { get; set; }
      public decimal Price { get; set; }
}