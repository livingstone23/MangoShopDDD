namespace MangoShop.Api.DTOs;

public class WhatsAppMessageDto
{

    public int Id { get; set; }
    public Guid Oui { get; set; }
    public string PhoneTo { get; set; }
    public string TemplanteNameUsed { get; set; }
    public string MessageBody { get; set; }
    public string MessageId { get; set; }
    public string PhoneFrom { get; set; }
    public string PhoneId { get; set; }
    public bool? SendingAt { get; set; }
    public DateTime? SendingDate { get; set; }
    public bool? DeliveredAt { get; set; }
    public DateTime? DeliveredDateConfirm { get; set; }
    public DateTime? DeliveredDateRegister { get; set; }
    public bool? ReadedAt { get; set; }
    public DateTime? ReadedDate { get; set; }
    public DateTime? ReadedDateRegister { get; set; }
    public bool? FailedAt { get; set; }
    public DateTime? FailedDate { get; set; }
    public DateTime? FailedDateRegister { get; set; }
}