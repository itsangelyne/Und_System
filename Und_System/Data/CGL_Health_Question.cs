using System.ComponentModel.DataAnnotations;

namespace Und_System.Data
{
    public class CGL_Health_Question
    {
        [Key]
        public int ID { get; set; }
        public double NO { get; set; }
        public  string? Question { get; set; }
        public  string? InputType { get; set; }
        public  string? Button { get; set; }
        public  string? ButtonText { get; set; }
        public  string? DropDown { get; set; }
        public  string? Status { get; set; }
    }
}
