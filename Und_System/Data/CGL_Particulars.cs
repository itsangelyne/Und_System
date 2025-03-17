using System.ComponentModel.DataAnnotations;

namespace Und_System.Data
{
    public class CGL_Particulars
    {
        [Key]
        public int ID_Particulars { get; set; }
        public int ID_CB { get; set; }
        public string? Particulars { get; set; }
        public double? Amount { get; set; }
        public string? ADD_LESS { get; set; }
    }
}
