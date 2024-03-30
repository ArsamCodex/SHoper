using Microsoft.EntityFrameworkCore;
using SHoper.Model;
using SHoper.Model.CasinoUsers;
using SHoper.Model.Emplyee;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SHoper.Data
{
    public class ApplicationDbMyData : DbContext
    {
        public ApplicationDbMyData(DbContextOptions<ApplicationDbMyData> options)
          : base(options)
        {
        }
        public DbSet<IncomingNumber> IncomingNumber { get; set; } = default!;
       public DbSet<CasinoPlayers> CasinoPlayers { get; set; } = default!;
        public DbSet<UserAsClient> UserAsClients { get; set; } = default!;
        public DbSet<Items> Items { get; set; } = default!;

        public DbSet<Basket> Baskets { get; set; } = default!;
        public DbSet<Employee> Employee { get; set; } = default!;
       // public DbSet<Department> Department { get; set; } = default!;
        public DbSet<Vacation> Vacation { get; set; } = default!;
        public DbSet<EmployeeTask> Task { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
            modelBuilder.Entity<Employee>()
                .HasMany(c => c.Vacations)
                .WithOne(e => e.Employees)
                .HasForeignKey(v => v.EmployeeID)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
            */
            /*
            // Configure the relationship between UserAsClient and Basket
            modelBuilder.Entity<UserAsClient>()
                .HasOne(u => u.Basket) // Corrected navigation property
                .WithOne(b => b.UserAsClient)
                .HasForeignKey<Basket>(b => b.UserAsClientId);

            // Configure the relationship between Basket and Items
            modelBuilder.Entity<Basket>()
      .HasMany(b => b.Item)
      .WithOne(i => i.Basket)
      .HasForeignKey(i => i.BasketId);*/
        }


    }
}
