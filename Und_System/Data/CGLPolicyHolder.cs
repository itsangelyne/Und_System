using System.ComponentModel.DataAnnotations;

namespace Und_System.Data
{
    public class CGLPolicyHolder
    {
        [Key]
        public int ID_Policy_Holder { get; set; }
        public required string Policy_Holder_Name { get; set; }
        public required string Master_Polno { get; set; }
        public required string Manager { get; set; }
        public required string Bank_Address { get; set; }
        public string? Bank_Level { get; set; }
        public string? Bank_Status { get; set; }
    }
}
