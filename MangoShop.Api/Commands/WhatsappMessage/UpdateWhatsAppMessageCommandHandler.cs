using MangoShop.Api.Helpers;
using MangoShop.Domain.Entities;
using MangoShop.Domain.Repositories;
using MediatR;



namespace MangoShop.Api.Commands.WhatsappMessage;



public class UpdateWhatsAppMessageCommandHandler : IRequestHandler<UpdateWhatsAppMessageCommand, Unit>
{
    private readonly IWhatsAppMessageRepository _whatsAppMessageRepository;

    public UpdateWhatsAppMessageCommandHandler(IWhatsAppMessageRepository whatsAppMessageRepository)
    {
        _whatsAppMessageRepository = whatsAppMessageRepository;
    }

    public async Task<Unit> Handle(UpdateWhatsAppMessageCommand request, CancellationToken cancellationToken)
    {

        var message = await _whatsAppMessageRepository.GetByIdAsync(request.Id);
        if (message == null)
        {
            throw new NotFoundException(nameof(WhatsAppMessage), request);
        }
        
        message.SendingAt = request.SendingAt;
        message.SendingDate = request.SendingDate;
        message.DeliveredAt = request.DeliveredAt;
        message.DeliveredDateConfirm = request.DeliveredDateConfirm;
        message.DeliveredDateRegister = request.DeliveredDateRegister;
        message.ReadedAt = request.ReadedAt;
        message.ReadedDate = request.ReadedDate;
        message.ReadedDateRegister = request.ReadedDateRegister;
        message.FailedAt = request.FailedAt;
        message.FailedDate = request.FailedDate;
        message.FailedDateRegister = request.FailedDateRegister;

        await _whatsAppMessageRepository.UpdateAsync(message);
        return Unit.Value;
    }
}