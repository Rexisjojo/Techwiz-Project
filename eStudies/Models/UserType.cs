using System.ComponentModel.DataAnnotations;

namespace eStudies.Models
{
    public class UserType
    {
        public int UserTypeId { get; set; }
        [MinLength(7,ErrorMessage ="Min 7 Character Required")]
        [MaxLength(50,ErrorMessage ="Max 50 Character Allowed")]
        [Display(Name="User Type")]
        public string TypeName { get; set; } 
    }
}
