using MangoShop.Domain.Entities;
using MangoShop.Infrastructure.Configuration;
using MangoShop.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using NUnit.Framework;

namespace MangoShop.Tests.DataAccess;



[TestFixture]
public class WhatsAppMessageRepositoryTest
{

    private ApplicationDbContext _context;
    private WhatsappMessageRepository _repository;


    //Sets up the test enviroment.
    [SetUp]
    public void Setup()
    {
        _repository = new WhatsappMessageRepository(_context);


        //Configure the in-memory database
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _context = new ApplicationDbContext(options);

        // create a logger
        //var logger = NullLogger< WhatsappMessageRepository>.Instance;

        _repository = new WhatsappMessageRepository(_context);

    }

    [Test]
    public async Task GetAll_ShouldReturnAllMessage()
    {
        //Arrange
        var message1 = new WhatsAppMessage
        {
            MessageId = "12345678910",
            PhoneFrom = "123456789",
            PhoneId = "123456789",
            PhoneTo = "123456789",
            MessageBody = "Hola Mundo",
            TemplanteNameUsed = "Template1",
            Created = DateTime.UtcNow
        };

        var message2 = new WhatsAppMessage
        {
            MessageId = "123456789",
            PhoneFrom = "123456789",
            PhoneId = "123456789",
            PhoneTo = "123456789",
            MessageBody = "Hola Mundo",
            TemplanteNameUsed = "Template1",
            Created = DateTime.UtcNow
        };

        await _context.WhatsAppMessages.AddRangeAsync(message1, message2);
        await _context.SaveChangesAsync();

        //Act
        var messages = await _repository.GetAllAsync();

        //Assert
        Assert.AreEqual(2, messages.Count);
    }


    [Test]
    public async Task GetById_ShouldReturnMessageById()
    {
        //Arrange
        var newWhatsAppMessage = new WhatsAppMessage
        {
            MessageId = "12345678910",
            PhoneFrom = "123456789",
            PhoneId = "123456789",
            PhoneTo = "123456789",
            MessageBody = "Hola Mundo",
            TemplanteNameUsed = "Template1",
            Created = DateTime.UtcNow
        };

        //Act
        await _context.WhatsAppMessages.AddAsync(newWhatsAppMessage);
        await _context.SaveChangesAsync();
        var addedEntity = await _repository.GetByIdAsync(newWhatsAppMessage.Id);

        //Assert
        Assert.AreEqual(newWhatsAppMessage.Id, addedEntity.Id);
        Assert.AreEqual(newWhatsAppMessage.MessageId, addedEntity.MessageId);

    }


    [Test]
    public async Task Add_ShouldRemoveFromDatabase()
    {
        //Arrange
        var newWhatsAppMessage = new WhatsAppMessage
        {
            MessageId = "12345678910",
            PhoneFrom = "123456789",
            PhoneId = "123456789",
            PhoneTo = "123456789",
            MessageBody = "Hola Mundo",
            TemplanteNameUsed = "Template1",
            Created = DateTime.UtcNow
        };

        await _repository.AddAsync(newWhatsAppMessage);


        //Act
        await _repository.DeleteAsync(newWhatsAppMessage.Id);

        
        //Assert
        Assert.AreEqual(0, _context.WhatsAppMessages.Count());


    }




}