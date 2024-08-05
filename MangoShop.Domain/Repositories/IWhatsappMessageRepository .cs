using MangoShop.Domain.Entities;



namespace MangoShop.Domain.Repositories;



public interface IWhatsAppMessageRepository
{
    Task<WhatsAppMessage> GetByIdAsync(Guid id);
    Task AddAsync(WhatsAppMessage message);
    Task UpdateAsync(WhatsAppMessage message);
    Task DeleteAsync(Guid id);
}