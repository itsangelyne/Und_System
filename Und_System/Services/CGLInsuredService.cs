using Microsoft.EntityFrameworkCore;
using Und_System.Context;
using Und_System.Data;

namespace Und_System.Services
{
    public class CGLInsuredService(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<List<CGLInsured>> GetInsuredAsync()
        {
            return await _context.CGL_INSURED.ToListAsync();
        }
        public async Task UpdateInsuredAsync(CGLInsured insured)
        {
            var existingInsured = await _context.CGL_INSURED.FindAsync(insured.ID_Insured);
            if (existingInsured != null)
            {
                existingInsured.First_Name = insured.First_Name;
                existingInsured.Last_Name = insured.Last_Name;
                existingInsured.Middle_Name = insured.Middle_Name;
                existingInsured.Suffix = insured.Suffix;
                existingInsured.Date_Of_Birth = insured.Date_Of_Birth;
                existingInsured.Age = insured.Age;
                await _context.SaveChangesAsync();
            }
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