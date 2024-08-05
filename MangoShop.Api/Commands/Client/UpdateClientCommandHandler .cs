using MangoShop.Api.Helpers;
using MangoShop.Domain.Repositories;
using MediatR;

namespace MangoShop.Api.Commands.Client;

public class UpdateClientCommandHandler : IRequestHandler<UpdateClientCommand, Unit>
{
    private readonly IClientRepository _clientRepository;

    public UpdateClientCommandHandler(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public async Task<Unit> Handle(UpdateClientCommand request, CancellationToken cancellationToken)
    {
        var client = await _clientRepository.GetByIdAsync(request.Id);
        if (client == null)
        {
            throw new NotFoundException(nameof(Client), request.Id);
        }

        client.Name = request.Name;
        client.Email = request.Email;
        client.Updated = DateTime.UtcNow;

        await _clientRepository.UpdateAsync(client);

        return Unit.Value;
    }
}