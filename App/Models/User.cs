using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class User
    {
        [Required(ErrorMessage = "First and Last Name should not be empty")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email should not be empty")]
        [EmailAddress]
        public string Email { get; set; }

        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$",
         ErrorMessage = "Phone number must be in 999-999-9999 format.")]
        [Required(ErrorMessage = "Phone Number should not be empty")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Password should not be empty")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password should not be empty")]
        public string PasswordConfirmation { get; set; }

    }
}