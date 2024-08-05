using MediatR;

namespace MangoShop.Api.Queries.WhatsappMessage;

public class GetWhatsappMessageByIdQuery : IRequest<WhatsAppMessageDto>
{
    public Guid Id { get; set; }
}