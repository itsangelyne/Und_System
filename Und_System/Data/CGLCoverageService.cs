using Microsoft.EntityFrameworkCore;
using Und_System.Context;

namespace Und_System.Data
{
    public class CGLCoverageService(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<List<CGLCoverage>> GetCoverageAsync()
        {
            return await _context.CGL_Coverage.ToListAsync();
        }
        public async Task<CGLCoverage?> GetCoverageByInsuredIdAsync(int insuredId)
        {
            return await _context.CGL_Coverage.FirstOrDefaultAsync(c => c.ID_Insured == insuredId);
        }
    }
}
