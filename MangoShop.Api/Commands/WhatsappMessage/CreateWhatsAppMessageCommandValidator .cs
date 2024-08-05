using FluentValidation;

namespace MangoShop.Api.Commands.WhatsappMessage;

public class CreateWhatsAppMessageCommandValidator : AbstractValidator<CreateWhatsappMessageCommand>
{
    public CreateWhatsAppMessageCommandValidator()
    {
        RuleFor(x => x.PhoneTo).NotEmpty().WithMessage("PhoneTo is required.");
        RuleFor(x => x.TemplanteNameUsed).NotEmpty().WithMessage("TemplanteNameUsed is required.");
        RuleFor(x => x.MessageBody).NotEmpty().WithMessage("MessageBody is required.");
        RuleFor(x => x.PhoneFrom).NotEmpty().WithMessage("PhoneFrom is required.");
    }
}