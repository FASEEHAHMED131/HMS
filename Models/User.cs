using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HMS.Models
{
    public class User
    {
        [Key]
        public int userid { get; set; }

        [Required(ErrorMessage = "user name is required")]
        [Display(Name = "User Name")]
        public string username { get; set; }

        [Required(ErrorMessage = "email is required")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Contact is required")]
        [Display(Name = "Contact")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Invalid Contact")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Date of Birth is Needed")]
        public DateTime DateofBirth { get; set; }

        [Required(ErrorMessage = "CNIC is Requried")]
        [StringLength(13,ErrorMessage = "Invalid CNIC")]
        public string CNIC { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        [MinLength(8,ErrorMessage = "Not Less than 8 Characters")]
        [MaxLength(25,ErrorMessage = "Not more than 25 Characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confrim Password is Required")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Not Less than 8 Characters")]
        [MaxLength(25, ErrorMessage = "Not more than 25 Characters")]
        [Compare("Password", ErrorMessage = "Password Doesn't Match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Enter the Gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please Agree to the terms and conditions")]
        public bool Agree { get; set; }
    }
}