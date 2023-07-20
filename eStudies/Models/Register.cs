using System.ComponentModel.DataAnnotations;

namespace eStudies.Models
{
    public class Register
    {
        public int RegisterId { get; set; }

        //
        [MinLength(3, ErrorMessage = "Minimun 3 char required")]
        [MaxLength(50, ErrorMessage = "Maximun 50 char allowed")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        //
        [DataType(DataType.EmailAddress)]
        [MinLength(3, ErrorMessage = "Minimun 3 char required")]
        [MaxLength(50, ErrorMessage = "Maximun 50 char required")]
        [Display(Name = "Email Address")]
        public string UserEmail { get; set; }
        //
        [DataType(DataType.Password)]
        [MinLength(3, ErrorMessage = "Minimun 3 char required")]
        [MaxLength(50, ErrorMessage = "Maximun 50 char required")]
        [Display(Name = "Password")]
        public string Password { get; set; }
        //
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password not Matched")]
        [MinLength(3, ErrorMessage = "Minimun 3 char required")]
        [MaxLength(50, ErrorMessage = "Maximun 50 char required")]
        [Display(Name = "Confirm Password")]
        public string CPassword { get; set; }
        //
        [MinLength(3, ErrorMessage = "Minimun 3 char required")]
        [MaxLength(50, ErrorMessage = "Maximun 50 char required")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        //
        [MinLength(10, ErrorMessage = "Minimun 10 char required")]
        [MaxLength(250, ErrorMessage = "Maximun 250 char required")]
        [Display(Name = "Address")]
        public string Address { get; set; }
        public int Age { get; set; }

        [Display(Name ="User Type")]
        public int UserTypeId { get; set; }
        public UserType UserType { get; set; }  
    }
}
