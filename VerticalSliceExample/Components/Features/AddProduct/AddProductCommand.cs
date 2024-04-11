using MediatR;

namespace VerticalSliceExample.Components.Features.AddProduct;

public class AddProductCommand : IRequest<AddProductResponse>
{
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}