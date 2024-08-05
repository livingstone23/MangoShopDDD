using MangoShop.Api.DTOs;
using MangoShop.Domain.Repositories;
using MediatR;

namespace MangoShop.Api.Queries.WhatsappMessage;

public class GetWhatsappMessageByIdQueryHandler : IRequestHandler<GetWhatsappMessageByIdQuery, WhatsAppMessageDto>
{
    private readonly IWhatsAppMessageRepository _repository;

    public GetWhatsappMessageByIdQueryHandler(IWhatsAppMessageRepository repository)
    {
        _repository = repository;
    }

    public async Task<WhatsAppMessageDto> Handle(GetWhatsappMessageByIdQuery request, CancellationToken cancellationToken)
    {
        var message = await _repository.GetByIdAsync(request.Id);
        return new WhatsAppMessageDto
        {
            Id = message.Id,
            PhoneTo = message.PhoneTo,
            TemplanteNameUsed = message.TemplanteNameUsed,
            MessageBody = message.MessageBody,
            MessageId = message.MessageId,
            PhoneFrom = message.PhoneFrom,
            PhoneId = message.PhoneId,
            SendingAt = message.SendingAt,
            SendingDate = message.SendingDate,
            DeliveredAt = message.DeliveredAt,
            DeliveredDateConfirm = message.DeliveredDateConfirm,
            DeliveredDateRegister = message.DeliveredDateRegister,
            ReadedAt = message.ReadedAt,
            ReadedDate = message.ReadedDate,
            ReadedDateRegister = message.ReadedDateRegister,
            FailedAt = message.FailedAt,
            FailedDate = message.FailedDate,
            FailedDateRegister = message.FailedDateRegister
        };
    }
}