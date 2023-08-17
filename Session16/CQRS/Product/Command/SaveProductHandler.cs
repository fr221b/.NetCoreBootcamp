
using System;
using MediatR;
using Session16.Models.Data.Context;
using Session16.Models.Data.Entities;

namespace CQRS.Product.Command;

public class SaveProductHandler : IRequestHandler<SaveProductCommand,SaveProductResponse>
{
    private readonly Context context;
    
    public SaveProductHandler(Context _context)
    {
        context= _context;
    }

    
        async Task<SaveProductResponse> IRequestHandler<SaveProductCommand, SaveProductResponse>.Handle(SaveProductCommand request, CancellationToken cancellationToken)
    {
         var product=new Tbl_Product()
        {
               Name=request.Name,
               Color=request.Color,
               Description=request.Description,
               Price=request.Price
        };
         await context.Tbl_Products.AddAsync(product,cancellationToken);
         await context.SaveChangesAsync(cancellationToken);
         return new SaveProductResponse { IsSuccess = true };
    }
    }
