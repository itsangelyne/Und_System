using System.ComponentModel.DataAnnotations;

namespace Und_System.Data
{
    public class CGL_UnderwritingUser
    {
        [Key]
        public int UserID { get; set; }
        public int EmployeeNo { get; set; }
        public required string First_Name { get; set; }
        public required string Last_Name { get; set; }
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string Department { get; set; }
        public required string User_Type { get; set; }
        public required string Status { get; set; }
    }
}
