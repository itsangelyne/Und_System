using System.ComponentModel.DataAnnotations;

namespace Und_System.Data
{
    public class CGLCoverage
    {
        [Key]
        public int ID_Coverage { get; set; }
        public int ID_Insured { get; set; }
        public double Amount_Of_Insured { get; set; }
        public DateTime Effective_Date { get; set; }
        public DateTime Termination_Date { get; set; }
        public required string Term_Of_Loan { get; set; }
        public int Payment_Duration { get; set; }
        public required string Mode_Of_Payment { get; set; }
        public double Premium_Orig { get; set; }
        public double Premium { get; set; }
        public required string Rider { get; set; }
    }
}
