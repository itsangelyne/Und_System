using Microsoft.EntityFrameworkCore;
using Und_System.Context;

namespace Und_System.Data
{
    public class CGLPolicyHolderServices(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        //Display Banks
        public async Task<List<CGLPolicyHolder>> GetBanksAsync()
        {
            return await _context.CGL_Policy_Holder.ToListAsync();
        }
        //To Add Bank
        public async Task AddBankAsync(CGLPolicyHolder bank)
        {
            _context.CGL_Policy_Holder.Add(bank);
            await _context.SaveChangesAsync();
        }
        public async Task<CGLPolicyHolder> GetPolicyHolderByIdAsync(int id)
        {
            return await _context.CGL_Policy_Holder.FindAsync(id); // Adjust according to your DbSet name
        }
    }
}
