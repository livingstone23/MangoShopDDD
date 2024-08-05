using MangoShop.Api.Helpers;
using MangoShop.Domain.Repositories;
using MediatR;

namespace MangoShop.Api.Commands.Product;

public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, Unit>
{
    private readonly IProductRepository _productRepository;

    public DeleteProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {

        var product = await _productRepository.GetByIdAsync(request.Id);
        if (product == null)
        {
            throw new NotFoundException(nameof(Product), request.Id);
        }
        await _productRepository.DeleteAsync(request.Id);
        return Unit.Value;
    }
}