

using MediatR;

namespace CQRS.Product.Command;
public class SaveProductCommand : IRequest<SaveProductResponse>
{
      public string Name { get; set; }
      public string Description { get; set; }
      public decimal Price { get; set; }
      public string Color { get; set; }
      
}