using System.ComponentModel.DataAnnotations;

namespace Und_System.Data
{
    public class CGL_WithNotice
    {
        [Key]
        public int NoticesID { get; set; }
        public int ID_Insured { get; set; }
        public DateTime Letter_Date { get; set; }
        public int Ref_No { get; set; }
        public string? Type_Of_Notice { get; set; }
        public string? Remarks { get; set; }
    }
}
