using Models;

namespace VerticalSliceExample.Components.Features.GetProduct;

public class GetProductResponse
{
    public bool IsSuccess { get; init; }
    public List<Product>? Products { get; init; }
}