using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DEESDrivingSchool.Models
{
    public class Login 
    {
        [Required(ErrorMessage ="Please Enter an Email Address")]
        [Display(Name ="Enter Email Address")]
        public string EmailAddress { get; set; }


           
        [Required(ErrorMessage = "Please Enter a Password")]
        [Display(Name = "Enter Password")]
        public string Password { get; set; }


    
        [Required(ErrorMessage = "Please Confirm your Password")]
        [Display(Name = " Re-Enter Password to Confirm your Password" )]
        public string ConPassword { get; set; }







    }
}