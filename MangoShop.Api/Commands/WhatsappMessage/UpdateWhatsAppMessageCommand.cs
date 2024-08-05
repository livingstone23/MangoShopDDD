using MediatR;

namespace MangoShop.Api.Commands.WhatsappMessage;

public class UpdateWhatsAppMessageCommand : IRequest<Unit>
{
    public Guid Oui { get; set; }
    public bool SendingAt { get; set; }
    public DateTime? SendingDate { get; set; }
    public bool DeliveredAt { get; set; }
    public DateTime? DeliveredDateConfirm { get; set; }
    public DateTime? DeliveredDateRegister { get; set; }
    public bool ReadedAt { get; set; }
    public DateTime? ReadedDate { get; set; }
    public DateTime? ReadedDateRegister { get; set; }
    public bool FailedAt { get; set; }
    public DateTime? FailedDate { get; set; }
    public DateTime? FailedDateRegister { get; set; }
}