using Microsoft.AspNetCore.Identity;
using SHoper.Model;

namespace SHoper.Interfaces
{
    public interface InterfaceOne
    {
        public  Task<List<Items>>? Items();
 
    }
}
