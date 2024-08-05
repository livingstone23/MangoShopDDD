using MangoShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;



namespace MangoShop.Infrastructure;



public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Client> Clients { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<WhatsAppMessage> WhatsAppMessages { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Configurations for entities
        // Configuración de la entidad Client
        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
            entity.Property(e => e.Email).IsRequired().HasMaxLength(50);
            entity.Property(e => e.Created).IsRequired(false);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.Updated).IsRequired(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.GcRecord).IsRequired(false);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
            entity.Property(e => e.Description).IsRequired().HasMaxLength(200);
            entity.Property(e => e.Price).IsRequired();
            entity.Property(e => e.Created).IsRequired(false);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.Updated).IsRequired(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.GcRecord).IsRequired(false);
        });

        // Configuración de la entidad WhatsAppMessage
        modelBuilder.Entity<WhatsAppMessage>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.PhoneTo).IsRequired().HasMaxLength(50);
            entity.Property(e => e.TemplanteNameUsed).IsRequired().HasMaxLength(200);
            entity.Property(e => e.MessageBody).HasMaxLength(3000);
            entity.Property(e => e.MessageId).IsRequired().HasMaxLength(50);
            entity.Property(e => e.PhoneFrom).IsRequired().HasMaxLength(20);
            entity.Property(e => e.PhoneId).HasMaxLength(50);
            entity.Property(e => e.SendingAt).IsRequired(false);
            entity.Property(e => e.SendingDate).IsRequired(false);
            entity.Property(e => e.DeliveredAt).IsRequired(false);
            entity.Property(e => e.DeliveredDateConfirm).IsRequired(false);
            entity.Property(e => e.DeliveredDateRegister).IsRequired(false);
            entity.Property(e => e.ReadedAt).IsRequired(false);
            entity.Property(e => e.ReadedDate).IsRequired(false);
            entity.Property(e => e.ReadedDateRegister).IsRequired(false);
            entity.Property(e => e.FailedAt).IsRequired(false);
            entity.Property(e => e.FailedDate).IsRequired(false);
            entity.Property(e => e.FailedDateRegister).IsRequired(false);
            entity.Property(e => e.Created).IsRequired(false);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.Updated).IsRequired(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.GcRecord).IsRequired(false);
        });
    }
}