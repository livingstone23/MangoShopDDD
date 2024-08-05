namespace MangoShop.Domain.Events.Product;

public class ProductCreatedEvent
{
    public int Id { get; }
    public Guid Oid { get; }
    public string Name { get; }
    public string Description { get; }
    public decimal Price { get; }
    public DateTime Created { get; }
    public string CreatedBy { get; }

    public ProductCreatedEvent(int id, Guid oid, string name, string description, decimal price, DateTime created, string createdBy)
    {
        Id = id;
        Oid = oid;
        Name = name;
        Description = description;
        Price = price;
        Created = created;
        CreatedBy = createdBy;
    }
}