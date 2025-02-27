using Microsoft.EntityFrameworkCore;
using Und_System.Context;

namespace Und_System.Data
{
    public class CGLCreditDebitServices(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<List<CGLCreditDebit>> GetCredDebitAsync()
        {
            return await _context.CGL_CreditDebit.ToListAsync();
        }
    }
}
