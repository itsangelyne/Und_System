using Microsoft.EntityFrameworkCore;
using Und_System.Context;
using Und_System.Data;

namespace Und_System.Services
{
    public class CGLParticularsService(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<List<CGL_Particulars>> GetParticularsAsync()
        {
            return await _context.CGL_Particulars.ToListAsync();
        }
        public async Task<List<CGL_Particulars>> GetParticularsByCreditDebitIdAsync(int idCB)
        {
            var result = await _context.CGL_Particulars
                .Where(p => p.ID_CB == idCB)
                .ToListAsync();

            return result ?? new List<CGL_Particulars>();
        }

    }
}
