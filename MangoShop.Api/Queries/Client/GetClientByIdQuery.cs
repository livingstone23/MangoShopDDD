using MangoShop.Api.DTOs;
using MediatR;

namespace MangoShop.Api.Queries.Client;

public class GetClientByIdQuery : IRequest<ClientDto>
{
    public Guid Id { get; set; }
}