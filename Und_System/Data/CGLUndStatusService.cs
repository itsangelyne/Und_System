using Microsoft.EntityFrameworkCore;
using Und_System.Context;

namespace Und_System.Data
{
    public class CGLUndStatusService(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<List<CGL_UndStatus>> GetStatusAsync()
        {
            return await _context.CGL_UndStatus.ToListAsync();
        }
    }
}

