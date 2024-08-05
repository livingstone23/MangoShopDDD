namespace MangoShop.Domain.Events.WhatsAppMessage;

public class WhatsAppMessageReadEvent
{
    public int Id { get; }
    public Guid Oui { get; }
    public DateTime ReadedDate { get; }
    public DateTime ReadedDateRegister { get; }

    public WhatsAppMessageReadEvent(int id, Guid oui, DateTime readedDate, DateTime readedDateRegister)
    {
        Id = id;
        Oui = oui;
        ReadedDate = readedDate;
        ReadedDateRegister = readedDateRegister;
    }
}