using MediatR;

namespace MangoShop.Api.Commands.Product;

public class CreateProductCommand : IRequest<Guid>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}