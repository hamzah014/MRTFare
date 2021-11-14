using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MRTFare.Models
{
    public class Users
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your name.")]
        [Display(Name = "Name")]
        public String Name { get; set; }


        [Required(ErrorMessage = "Please enter your IC/Passport.")]
        [Display(Name = "IC/Passport")]
        public String IcNo { get; set; }


        [Required(ErrorMessage = "Please enter your email.")]
        [Display(Name = "Email")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Please enter your password.")]
        [Display(Name = "Password")]
        public String Password { get; set; }

        public String Role { get; set; }


    }
}
