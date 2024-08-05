using MediatR;

namespace MangoShop.Api.Commands.Client;

public class CreateClientCommand : IRequest<Guid>
{
    public string Name { get; set; }
    public string Email { get; set; }
}