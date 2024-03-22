using Microsoft.EntityFrameworkCore;
using SHoper.Data;

namespace SHoper.Services
{
    public class ChangeRoleService
    {
        private readonly ApplicationDbContext _context;

        public ChangeRoleService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> ChangeUserRole(string userId, string roleId)
        {
            try
            {
                var userRole = await _context.UserRoles.FirstOrDefaultAsync(ur => ur.UserId == userId);
                if (userRole != null)
                {
                    userRole.RoleId = roleId;
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
