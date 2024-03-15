using Microsoft.EntityFrameworkCore;
using SHoper.Model;

namespace SHoper.Data
{
    public class ApplicationDbMyData :DbContext
    {
        public ApplicationDbMyData(DbContextOptions<ApplicationDbMyData> options)
          : base(options)
        {
        }
        public DbSet<UserAsClient> UserAsClient { get; set; } = default!;
        public DbSet<Items> Items { get; set; } = default!;
        
    }
}
