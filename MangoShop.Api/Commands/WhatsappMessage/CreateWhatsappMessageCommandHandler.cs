using MediatR;

namespace MangoShop.Api.Commands.WhatsappMessage;

public class CreateWhatsappMessageCommandHandler : IRequestHandler<CreateWhatsappMessageCommand, Guid>
{
    private readonly IWhatsappMessageRepository _repository;

    public CreateWhatsappMessageCommandHandler(IWhatsappMessageRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(CreateWhatsappMessageCommand request, CancellationToken cancellationToken)
    {
        var message = new WhatsAppMessage
        {
            Oui = Guid.NewGuid(),
            PhoneTo = request.PhoneTo,
            TemplanteNameUsed = request.TemplanteNameUsed,
            MessageBody = request.MessageBody,
            MessageId = request.MessageId,
            PhoneFrom = request.PhoneFrom,
            PhoneId = request.PhoneId,
            Created = DateTime.UtcNow,
            CreatedBy = "system"
        };
        await _repository.AddAsync(message);
        return message.Oui;
    }
}