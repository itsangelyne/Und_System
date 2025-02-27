using System.ComponentModel.DataAnnotations;

namespace Und_System.Data
{
    public class CGLInsured
    {
        [Key]
        public int ID_Insured { get; set; }
        public required string DCHS { get; set; }
        public int ID_Policy_Holder { get; set; }
        public required string First_Name { get; set; }
        public string? Middle_Name { get; set; }
        public required string Last_Name { get; set; }
        public string? Suffix { get; set; }
        public required string Civil_Status { get; set; }
        public required string Gender { get; set; }
        public required string Height { get; set; }
        public required string Weight { get; set; }
        public required string Address { get; set; }
        public required string Contact_Number { get; set; }
        public required string Email_Address { get; set; }
        public int Age { get; set; }
        public DateTime Date_Of_Birth { get; set; }
        public required string Place_Of_Birth { get; set; }
        public required string Nationality { get; set; }
        public required string TIN_SSS_GSIS_NO { get; set; }
        public required string Source_Of_Funds { get; set; }
        public required string Nature_of_Self_Employment_Business { get; set; }
        public required string Address_Of_Business_or_Employer { get; set; }
        public required string Occupation_And_Livelihood { get; set; }
        public string? Pregnant { get; set; }
        public string? How_Many_Months { get; set; }
        public string? Image { get; set; }
        public string? Type { get; set; }
    }
}