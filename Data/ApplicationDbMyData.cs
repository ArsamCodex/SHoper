using Microsoft.EntityFrameworkCore;

namespace SHoper.Data
{
    public class ApplicationDbMyData :DbContext
    {
        public ApplicationDbMyData(DbContextOptions<ApplicationDbMyData> options)
          : base(options)
        {
        }
    }
}
