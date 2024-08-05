using MangoShop.Domain.Entities;
using MangoShop.Domain.Repositories;
using MangoShop.Infrastructure.Configuration;

namespace MangoShop.Infrastructure.Repositories;

public class WhatsappMessageRepository : IWhatsAppMessageRepository
{


    private readonly ApplicationDbContext _context;


    public WhatsappMessageRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<WhatsAppMessage> GetByIdAsync(Guid id)
    {
        return await _context.WhatsAppMessages.FindAsync(id);
    }

    public async Task AddAsync(WhatsAppMessage message)
    {
        await _context.WhatsAppMessages.AddAsync(message);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(WhatsAppMessage message)
    {
        _context.WhatsAppMessages.Update(message);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var message = await _context.WhatsAppMessages.FindAsync(id);
        if (message != null)
        {
            _context.WhatsAppMessages.Remove(message);
            await _context.SaveChangesAsync();
        }
    }
}