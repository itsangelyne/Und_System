using Microsoft.EntityFrameworkCore;
using Und_System.Context;

namespace Und_System.Data
{
    public class CGLInsuredService(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<List<CGLInsured>> GetTestInformationAsync()
        {
            return await _context.CGL_INSURED.ToListAsync();
        }
        public async Task UpdateTestInformationAsync(CGLInsured employee)
        {
            _context.CGL_INSURED.Update(employee);
            await _context.SaveChangesAsync();
        }
        //public async Task UpdateLoanAsync(CGLInsured loan)
        //{
        //    var existingLoan = await _context.CGL_INSURED.FindAsync(loan.ID);
        //    if (existingLoan != null)
        //    {
        //        existingLoan.MultipleLoan = loan.MultipleLoan;
        //        await _context.SaveChangesAsync();
        //    }
        //}
        //public async Task<CGLInsured?> GetTestInformationByIdAsync(int id)
        //{
        //    return await _context.TestInformation.FirstOrDefaultAsync(ti => ti.ID == id);
        //}


    }
}