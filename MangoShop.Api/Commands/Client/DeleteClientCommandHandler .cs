using MangoShop.Api.Helpers;
using MangoShop.Domain.Repositories;
using MediatR;

namespace MangoShop.Api.Commands.Client;

public class DeleteClientCommandHandler : IRequestHandler<DeleteClientCommand, Unit>
{
    private readonly IClientRepository _clientRepository;

    public DeleteClientCommandHandler(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public async Task<Unit> Handle(DeleteClientCommand request, CancellationToken cancellationToken)
    {

        var client = await _clientRepository.GetByIdAsync(request.Id);
        if (client == null)
        {
            throw new NotFoundException(nameof(Client), request.Id);
        }

        await _clientRepository.DeleteAsync(request.Id);
        return Unit.Value;
    }
}