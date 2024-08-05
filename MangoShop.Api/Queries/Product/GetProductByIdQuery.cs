using MangoShop.Api.DTOs;
using MediatR;

namespace MangoShop.Api.Queries.Product;

public class GetProductByIdQuery : IRequest<ProductDto>
{
    public Guid Id { get; set; }
}