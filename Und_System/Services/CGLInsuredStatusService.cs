using Microsoft.EntityFrameworkCore;
using Und_System.Context;
using Und_System.Data;

namespace Und_System.Services
{
    public class CGLInsuredStatusService(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<List<CGL_Insured_Status>> GetStatusAsync()
        {
            return await _context.CGL_Insured_Status.ToListAsync();
        }
    }
}
