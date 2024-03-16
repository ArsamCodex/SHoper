using Microsoft.EntityFrameworkCore;
using SHoper.Model;

namespace SHoper.Data
{
    public class ApplicationDbMyData : DbContext
    {
        public ApplicationDbMyData(DbContextOptions<ApplicationDbMyData> options)
          : base(options)
        {
        }
        public DbSet<UserAsClient> UserAsClients { get; set; } = default!;
        public DbSet<Items> Items { get; set; } = default!;

        public DbSet<Basket> Baskets { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the relationship between UserAsClient and Basket
            modelBuilder.Entity<UserAsClient>()
                .HasOne(u => u.Basket) // Corrected navigation property
                .WithOne(b => b.UserAsClient)
                .HasForeignKey<Basket>(b => b.UserAsClientId);

            // Configure the relationship between Basket and Items
            modelBuilder.Entity<Basket>()
      .HasMany(b => b.Item)
      .WithOne(i => i.Basket)
      .HasForeignKey(i => i.BasketId);
        }


    }
}
