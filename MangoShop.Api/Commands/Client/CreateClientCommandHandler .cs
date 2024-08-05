using MangoShop.Domain.Repositories;
using MediatR;

namespace MangoShop.Api.Commands.Client;

public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, Guid>
{
    private readonly IClientRepository _clientRepository;

    public CreateClientCommandHandler(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public async Task<Guid> Handle(CreateClientCommand request, CancellationToken cancellationToken)
    {
        var client = new Domain.Entities.Client
        {
            Oid = Guid.NewGuid(),
            Name = request.Name,
            Email = request.Email,
            Created = DateTime.UtcNow
        };

        await _clientRepository.AddAsync(client);
        return client.Oid;
    }
}