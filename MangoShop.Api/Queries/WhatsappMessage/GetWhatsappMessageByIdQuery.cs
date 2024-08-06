using MangoShop.Api.DTOs;
using MediatR;

namespace MangoShop.Api.Queries.WhatsappMessage;

public class GetWhatsappMessageByIdQuery : IRequest<WhatsAppMessageDto>
{
    public int Id { get; set; }
}