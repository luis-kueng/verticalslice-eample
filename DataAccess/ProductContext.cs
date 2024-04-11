using Models;

namespace DataAccess;

public abstract class ProductContext
{
    public static List<Product> Products { get; set; }

    static ProductContext()
    {
        Products = new List<Product>()
        {
            new() { Name = "Book", Price = 15.3m, Quantity = 16 },
            new() { Name = "Chair", Price = 73.8m, Quantity = 3 },
            new() { Name = "Potato", Price = 0.35m, Quantity = 69 },
            new() { Name = "Tomato", Price = 0.10m, Quantity = 132 }
        };
    }
}