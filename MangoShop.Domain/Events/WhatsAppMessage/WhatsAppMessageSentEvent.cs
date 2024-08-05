namespace MangoShop.Domain.Events.WhatsAppMessage;

public class WhatsAppMessageSentEvent
{
    public int Id { get; }
    public Guid Oui { get; }
    public DateTime SendingDate { get; }

    public WhatsAppMessageSentEvent(int id, Guid oui, DateTime sendingDate)
    {
        Id = id;
        Oui = oui;
        SendingDate = sendingDate;
    }
}