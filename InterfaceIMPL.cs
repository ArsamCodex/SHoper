using SHoper.Data;
using SHoper.Interfaces;
using SHoper.Model;

namespace SHoper
{
    public class InterfaceIMPL : InterfaceOne
    {
        private readonly ApplicationDbMyData _context;

        public InterfaceIMPL(ApplicationDbMyData context, IHttpClientFactory httpClientFactory)
        {
            _context = context;

        }
        public List<Items>? Items()
        {
           return _context.Items.Where(c => c.UserAsClientID == null).ToList();
        }
    }
}
