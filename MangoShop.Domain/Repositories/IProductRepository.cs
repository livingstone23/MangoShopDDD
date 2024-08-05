using MangoShop.Domain.Entities;



namespace MangoShop.Domain.Repositories;



public interface IProductRepository
{
    Task<Product> GetByIdAsync(Guid id);
    Task AddAsync(Product product);
    Task UpdateAsync(Product product);
    Task DeleteAsync(Guid id);
}