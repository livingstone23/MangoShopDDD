namespace MangoShop.Domain.Events.WhatsAppMessage;

public class WhatsAppMessageFailedEvent
{
    public int Id { get; }
    public Guid Oui { get; }
    public DateTime FailedDate { get; }
    public DateTime FailedDateRegister { get; }

    public WhatsAppMessageFailedEvent(int id, Guid oui, DateTime failedDate, DateTime failedDateRegister)
    {
        Id = id;
        Oui = oui;
        FailedDate = failedDate;
        FailedDateRegister = failedDateRegister;
    }
}