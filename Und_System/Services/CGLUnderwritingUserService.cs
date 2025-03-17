using Microsoft.EntityFrameworkCore;
using Und_System.Context;
using Und_System.Data;
using Und_System.Pages;

namespace Und_System.Services
{
    public class CGLUnderwritingUserService
    {
        private readonly ApplicationDbContext _context;

        public CGLUnderwritingUserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<CGL_UnderwritingUser>> GetUserAsync()
        {
            return await _context.CGL_UnderwritingUser.ToListAsync();
        }

        public async Task UpdateUserStatusAsync(CGL_UnderwritingUser users)
        {
            var existingUser = await _context.CGL_UnderwritingUser.FindAsync(users.UserID);
            if (existingUser != null)
            {
                existingUser.Status = users.Status;
                await _context.SaveChangesAsync();
            }
        }
    }
}
