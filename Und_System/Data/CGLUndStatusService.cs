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
        public async Task UpdateStatusAsync(CGL_UndStatus status)
        {
            var existingStatus = await _context.CGL_UndStatus.FindAsync(status.UndStatusID);
            if (existingStatus != null)
            {
                existingStatus.Und_Status = status.Und_Status;
                existingStatus.PSD_Status = status.PSD_Status;
                existingStatus.Remarks = status.Remarks;

                await _context.SaveChangesAsync();
            }
        }
    }
}

