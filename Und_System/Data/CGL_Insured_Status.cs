using System.ComponentModel.DataAnnotations;

namespace Und_System.Data
{
    public class CGL_Insured_Status
    {
        [Key]
        public int ID_Status { get; set; }
        public int ID_Insured { get; set; }
        public string? Status { get; set; }
    }
}
