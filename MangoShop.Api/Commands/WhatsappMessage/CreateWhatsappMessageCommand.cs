using MediatR;

namespace MangoShop.Api.Commands.WhatsappMessage;

public class CreateWhatsappMessageCommand : IRequest<Guid>
{
    public string PhoneTo { get; set; }
    public string TemplanteNameUsed { get; set; }
    public string? MessageBody { get; set; }
    public string MessageId { get; set; }
    public string PhoneFrom { get; set; }
    public string? PhoneId { get; set; }
}