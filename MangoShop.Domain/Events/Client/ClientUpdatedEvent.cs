namespace MangoShop.Domain.Events.Client;

public class ClientUpdatedEvent
{
    public int Id { get; }
    public Guid Oid { get; }
    public string Name { get; }
    public string Email { get; }
    public DateTime Updated { get; }
    public string UpdatedBy { get; }

    public ClientUpdatedEvent(int id, Guid oid, string name, string email, DateTime updated, string updatedBy)
    {
        Id = id;
        Oid = oid;
        Name = name;
        Email = email;
        Updated = updated;
        UpdatedBy = updatedBy;
    }
}