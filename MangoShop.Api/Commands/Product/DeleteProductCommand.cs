using MediatR;

namespace MangoShop.Api.Commands.Product;

public class DeleteProductCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}