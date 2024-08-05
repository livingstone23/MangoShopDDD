using MangoShop.Domain.Repositories;
using MediatR;



namespace MangoShop.Api.Commands.Product;



public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
{
    private readonly IProductRepository _productRepository;

    public CreateProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Domain.Entities.Product
        {
            Oid = Guid.NewGuid(),
            Name = request.Name,
            Description = request.Description,
            Price = request.Price,
            Created = DateTime.UtcNow
        };

        await _productRepository.AddAsync(product);
        return product.Oid;
    }
}