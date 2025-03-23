using System.ComponentModel.DataAnnotations;

namespace Und_System.Data
{
    public class CGL_UndStatus
    {
        [Key]
        public int UndStatusID { get; set; }
        public int InsuredID { get; set; }
        public required string Und_Status { get; set; }
        public required string PSD_Status { get; set; }
        public required string Receive_Status { get; set; }
        public string? Receive_Date { get; set; }
        public string? Multiple_Loan { get; set; }
        public string? Remarks { get; set; }
        public string? ExtendedAge { get; set; }
      
    }
}
