using DataAccess;
using MediatR;

namespace VerticalSliceExample.Components.Features.GetProduct;

public class GetProductHandler : IRequestHandler<GetProductQuery, GetProductResponse>
{
    public Task<GetProductResponse> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        var products = ProductContext.Products.ToList();

        return Task.FromResult(new GetProductResponse()
        {
            IsSuccess = true,
            Products = products
        });
    }
}