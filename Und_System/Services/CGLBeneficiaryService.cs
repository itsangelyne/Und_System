using Microsoft.EntityFrameworkCore;
using Und_System.Context;
using Und_System.Data;

namespace Und_System.Services
{
    public class CGLBeneficiaryService(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<List<CGL_Beneficiary>> GetBeneficiariesAsync()
        {
            return await _context.CGL_Beneficiary.ToListAsync();
        }
        public async Task<List<CGL_Beneficiary>> GetByInsuredIdAsync(int id)
        {
            return await _context.CGL_Beneficiary
                .Where(a => a.ID_Insured == id)
                .ToListAsync();
        }
    }
}
