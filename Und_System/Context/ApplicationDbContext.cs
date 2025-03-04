using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Und_System.Data;

namespace Und_System.Context
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<CGLInsured> CGL_INSURED { get; set; }
        public DbSet<CGLCreditDebit> CGL_CreditDebit { get; set; }
        public DbSet<CGLPolicyHolder> CGL_Policy_Holder { get; set; }
        public DbSet<CGL_Insured_Status> CGL_Insured_Status { get; set; }
        public DbSet<CGLCoverage> CGL_Coverage { get; set; }
        public DbSet<CGL_UndStatus> CGL_UndStatus { get; set; }
        public DbSet<CGL_Substandard_Rating> CGL_Substandard_Rating { get; set; }
        public DbSet<CGL_Health_Question> CGL_HEALTH_QUESTION { get; set; }
        public DbSet<CGL_Health_Answer> CGL_Health_Answer { get; set; }
        public DbSet<CGL_Beneficiary> CGL_Beneficiary { get; set; }
    }
}