using MangoShop.Domain.Entities;
using MangoShop.Domain.Repositories;
using MediatR;

namespace MangoShop.Api.Commands.WhatsappMessage;

public class CreateWhatsAppMessageCommandHandler : IRequestHandler<CreateWhatsappMessageCommand, Guid>
{                                                                  
    private readonly IWhatsAppMessageRepository _whatsAppMessageRepository;

    public CreateWhatsAppMessageCommandHandler(IWhatsAppMessageRepository whatsAppMessageRepository)
    {
        _whatsAppMessageRepository = whatsAppMessageRepository;
    }

    public async Task<Guid> Handle(CreateWhatsappMessageCommand request, CancellationToken cancellationToken)
    {
        var message = new WhatsAppMessage
        {
            Oui = Guid.NewGuid(),
            PhoneTo = request.PhoneTo,
            TemplanteNameUsed = request.TemplanteNameUsed,
            MessageBody = request.MessageBody,
            PhoneFrom = request.PhoneFrom,
            PhoneId = request.PhoneId,
            Created = DateTime.UtcNow
        };

        await _whatsAppMessageRepository.AddAsync(message);
        return message.Oui;
    }
}