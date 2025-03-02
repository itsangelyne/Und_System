using Microsoft.EntityFrameworkCore;
using Und_System.Context;

namespace Und_System.Data
{
    public class CGLSubstandardRatingService(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<List<CGL_Substandard_Rating>> GetSubstandardAsync()
        {
            return await _context.CGL_Substandard_Rating.ToListAsync();
        }
        public async Task<List<CGL_Substandard_Rating>> GetByInsuredIdAsync(int id)
        {
            return await _context.CGL_Substandard_Rating
                .Where(s => s.ID_Insured == id)
                .ToListAsync();
        }
    }
}
