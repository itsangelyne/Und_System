using System.ComponentModel.DataAnnotations;

namespace Und_System.Data
{
    public class CGLCreditDebit
    {
        [Key]
        public int ID_CB { get; set; }
        public int ID_Policy_Holder { get; set; }
        public required string DCHS_From { get; set; }
        public required string DCHS_To { get; set; }
        public DateTime Period_From { get; set; }
        public DateTime Period_To { get; set; }
        public double Gross_Pay { get; set; }
        public double Net_Pay { get; set; }
        public int Total_Application { get; set; }
        public double Total_Coverage { get; set; }
        public DateTime Submitted_Date { get; set; }
        public required string Submitted_By { get; set; }
        public required string Receipt { get; set; }
    }
}
