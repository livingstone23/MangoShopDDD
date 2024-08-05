namespace MangoShop.Domain.Events.WhatsAppMessage;

public class WhatsAppMessageCreatedEvent
{
    public int Id { get; }
    public Guid Oui { get; }
    public string PhoneTo { get; }
    public string PhoneFrom { get; }
    public string TemplanteNameUsed { get; }
    public string MessageBody { get; }
    public DateTime Created { get; }
    public string CreatedBy { get; }

    public WhatsAppMessageCreatedEvent(int id, Guid oui, string phoneTo, string phoneFrom, string templanteNameUsed, string messageBody, DateTime created, string createdBy)
    {
        Id = id;
        Oui = oui;
        PhoneTo = phoneTo;
        PhoneFrom = phoneFrom;
        TemplanteNameUsed = templanteNameUsed;
        MessageBody = messageBody;
        Created = created;
        CreatedBy = createdBy;
    }
}