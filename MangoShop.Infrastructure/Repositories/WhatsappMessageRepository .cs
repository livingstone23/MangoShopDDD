namespace MangoShop.Infrastructure.Repositories;

public class WhatsappMessageRepository : IWhatsappMessageRepository
{
    private readonly YourDbContext _context;

    public WhatsappMessageRepository(YourDbContext context)
    {
        _context = context;
    }

    public async Task<WhatsAppMessage> GetByIdAsync(Guid id)
    {
        return await _context.WhatsAppMessages.FindAsync(id);
    }

    public async Task AddAsync(WhatsAppMessage message)
    {
        _context.WhatsAppMessages.Add(message);
        await _context.SaveChangesAsync();
    }
}