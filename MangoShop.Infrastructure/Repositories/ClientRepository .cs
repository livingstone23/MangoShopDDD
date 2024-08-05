﻿using MangoShop.Domain.Entities;
using MangoShop.Domain.Repositories;
using MangoShop.Infrastructure.Configuration;



namespace MangoShop.Infrastructure.Repositories;



public class ClientRepository : IClientRepository
{


    private readonly ApplicationDbContext _context;


    public ClientRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Client> GetByIdAsync(Guid id)
    {
        return await _context.Clients.FindAsync(id);
    }

    public async Task AddAsync(Client client)
    {
        await _context.Clients.AddAsync(client);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Client client)
    {
        _context.Clients.Update(client);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var client = await _context.Clients.FindAsync(id);
        if (client != null)
        {
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
        }
    }
}