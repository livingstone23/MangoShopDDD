using MangoShop.Domain.Entities;
using MangoShop.Domain.Repositories;
using MangoShop.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace MangoShop.Infrastructure.Repositories;

public class WhatsappMessageRepository : IWhatsAppMessageRepository
{


    private readonly ApplicationDbContext _context;


    public WhatsappMessageRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<WhatsAppMessage>> GetAllAsync()
    {

        return await _context.WhatsAppMessages.ToListAsync();

    }

    public async Task<WhatsAppMessage> GetByIdAsync(int id)
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

    public async Task DeleteAsync(int id)
    {
        var message = await _context.WhatsAppMessages.FindAsync(id);
        if (message != null)
        {
            _context.WhatsAppMessages.Remove(message);
            await _context.SaveChangesAsync();
        }
    }

    public  async Task<bool> SendMessage(WhatsAppMessage message)
    {

        if (string.IsNullOrEmpty(message.PhoneFrom) || string.IsNullOrEmpty(message.PhoneId))
        {
            return false;
        }
        // Simulación de envío de mensaje con una espera asincrónica
        await Task.Delay(1000); // Simula una ope

        // Simulación de envío de mensaje
        return true;

    }
}