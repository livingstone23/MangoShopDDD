using MangoShop.Domain.Entities;



namespace MangoShop.Domain.Repositories;



public interface IWhatsAppMessageRepository
{
    Task<WhatsAppMessage> GetByIdAsync(int id);
    Task AddAsync(WhatsAppMessage message);
    Task UpdateAsync(WhatsAppMessage message);
    Task DeleteAsync(int id);
}