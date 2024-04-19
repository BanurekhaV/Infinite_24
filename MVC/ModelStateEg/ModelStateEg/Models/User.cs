using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ModelStateEg.Models
{
    public class User
    {
        [Required(ErrorMessage ="First name is a must")]
        [Display(Name = "First Name ")]
        [StringLength(25, ErrorMessage ="First Name can only be upto 25 characters")]
        public string Firstname { get; set; }
        [DisplayName ("Last Name")]
        public string Lastname { get; set; } 
        [DisplayName("Age")]
        public int age { get; set; }
        [Required(ErrorMessage ="Email cannot be blank")]
        [Display(Name= "Email Address")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})$",ErrorMessage =
            "Invalid Email Id")]
        public string email { get; set; }
    }
}