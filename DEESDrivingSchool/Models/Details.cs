using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;



namespace DEESDrivingSchool.Models
{
    public class Details
    {

        [Key]
        public string RegID { get; set; }

        [Required(ErrorMessage ="Please Enter your Firstname")]
        [Display(Name ="First Name")]
        public string Fisrtname { get; set; }


        [Required(ErrorMessage ="Please Enter your Lastname")]
        [Display(Name ="Last Name")]
        public string Lastname { get; set; }

        [Required(ErrorMessage ="Please Select a Gender")]
        [Display(Name ="Gender")]
        public string Gender { get; set; }


        [Required(ErrorMessage ="Please Enter ID Number")]
        [Display(Name ="Identity Number")]
        public string IDno { get; set; }


        [Display(Name ="Date of Birth")]
        public string DOB { get; set; }

        [Display(Name ="Age")]
        public string Age { get; set; }

        [Required]
        [Display(Name ="Contact Number")]
        public string Contact { get; set; }
        
       
        [Display(Name ="Email Address")]
        public string EmailAddress { get; set; }



    }
}