using System.ComponentModel.DataAnnotations;

namespace Core.Domain.User;
public class MProduct
{
    [Key]
      public int ProductID { get; set;}
      public string ProductName { get; set; }
      public string Category { get; set; }
      public decimal Price { get; set; }
      public int Quantity { get; set; }
}