using MediatR;

namespace MangoShop.Api.Commands.Client;

public class DeleteClientCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}