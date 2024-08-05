using MediatR;

namespace MangoShop.Api.Commands.Client;

public class UpdateClientCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}