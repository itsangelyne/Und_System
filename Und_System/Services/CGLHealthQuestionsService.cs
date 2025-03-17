using Microsoft.EntityFrameworkCore;
using Und_System.Context;
using Und_System.Data;

namespace Und_System.Services
{
    public class CGLHealthQuestionsService(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<List<CGL_Health_Question>> GetSubstandardAsync()
        {
            return await _context.CGL_HEALTH_QUESTION.ToListAsync();
        }
    }
}