using MangoShop.Domain.Entities;



namespace MangoShop.Domain.Repositories;



public interface IClientRepository
{
    Task<Client> GetByIdAsync(Guid id);
    Task AddAsync(Client client);
    Task UpdateAsync(Client client);
    Task DeleteAsync(Guid id);
}