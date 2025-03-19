using Microsoft.EntityFrameworkCore;
using Und_System.Context;
using Und_System.Data;

namespace Und_System.Services
{
    public class CGLCreditDebitServices(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<List<CGLCreditDebit>> GetCredDebitAsync()
        {
            return await _context.CGL_CreditDebit.ToListAsync();
        }
        public async Task<CGLCreditDebit?> GetCreditDebitByIdAsync(int id)
        {
            return await _context.CGL_CreditDebit.FirstOrDefaultAsync(c => c.ID_CB == id);
        }
    }
}
