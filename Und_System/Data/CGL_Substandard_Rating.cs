using System.ComponentModel.DataAnnotations;

namespace Und_System.Data
{
    public class CGL_Substandard_Rating
    {
        [Key]
        public int ID_Substandard_Rating { get; set; }
        public int ID_Insured { get; set; }
        public required string Illness_Name { get; set; }
        public string? Regular_Age { get; set; }
        public string? Overage { get; set; }

    }
}
