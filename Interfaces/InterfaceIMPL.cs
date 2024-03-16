using Microsoft.EntityFrameworkCore;
using SHoper.Data;
using SHoper.Model;

namespace SHoper.Interfaces
{
    public class InterfaceIMPL : InterfaceOne
    {
        private readonly ApplicationDbMyData _context;

        public InterfaceIMPL(ApplicationDbMyData context)
        {
            _context = context;

        }

  
        public async Task<List<Items>>? Items()
        {
            return await _context.Items.Where(c => c.BasketId == null).ToListAsync();
         
        }
    }
}
