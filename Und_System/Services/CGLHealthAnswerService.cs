using Microsoft.EntityFrameworkCore;
using Und_System.Context;
using Und_System.Data;

namespace Und_System.Services
{
    public class CGLHealthAnswerService(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<List<CGL_Health_Answer>> GetSubstandardAsync()
        {
            return await _context.CGL_Health_Answer.ToListAsync();
        }
        public async Task<List<CGL_Health_Answer>> GetByInsuredIdAsync(int id)
        {
            return await _context.CGL_Health_Answer
                .Where(a => a.ID_Insured == id)
                .ToListAsync();
        }
    }
}
