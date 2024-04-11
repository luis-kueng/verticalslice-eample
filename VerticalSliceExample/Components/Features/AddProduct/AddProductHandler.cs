using DataAccess;
using MediatR;
using Models;

namespace VerticalSliceExample.Components.Features.AddProduct;

public class AddProductHandler : IRequestHandler<AddProductCommand, AddProductResponse>
{
    public Task<AddProductResponse> Handle(AddProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product()
        {
            Name = request.Name,
            Price = request.Price,
            Quantity = request.Quantity
        };
        
        ProductContext.Products.Add(product);

        return Task.FromResult(new AddProductResponse()
        {
            IsSuccess = true,
            ProductsInDatabase = ProductContext.Products.Count
        });
    }
}