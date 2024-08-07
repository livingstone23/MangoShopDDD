using MangoShop.Domain.Entities;



namespace MangoShop.Domain.Repositories;



public interface IWhatsAppMessageRepository
{
    Task<List<WhatsAppMessage>> GetAllAsync();
    Task<WhatsAppMessage> GetByIdAsync(int id);
    Task AddAsync(WhatsAppMessage message);
    Task UpdateAsync(WhatsAppMessage message);
    Task DeleteAsync(int id);

    Task<bool> SendMessage(WhatsAppMessage message);

}