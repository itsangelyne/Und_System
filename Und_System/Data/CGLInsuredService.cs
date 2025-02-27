using Microsoft.EntityFrameworkCore;
using Und_System.Context;

namespace Und_System.Data
{
    public class CGLInsuredService(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<List<CGLInsured>> GetInsuredAsync()
        {
            return await _context.CGL_INSURED.ToListAsync();
        }
        public async Task UpdateInsuredAsync(CGLInsured employee)
        {
            _context.CGL_INSURED.Update(employee);
            await _context.SaveChangesAsync();
        }
        public async Task<List<CGLInsured>> GetInsuredRecordsAsync()
        {
            return await _context.CGL_INSURED.ToListAsync();
        }
        public async Task<CGLInsured?> GetInsuredByIdAsync(int id)
        {
            return await _context.CGL_INSURED.FirstOrDefaultAsync(i => i.ID_Insured == id);
        }
    }
}