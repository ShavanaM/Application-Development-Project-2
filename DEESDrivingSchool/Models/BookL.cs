using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace DEESDrivingSchool.Models
{
    public class BookL
   {
        [Display(Name ="Book ID")]
        public string BookIDL { get; set; }

        [Required(ErrorMessage ="Please Select a Vehicle Code")]
        [Display(Name ="Vehicle Code")]
        public string Code { get; set; }

        [Display(Name = "")]
        public string DurationDate { get; set; }

        [Required(ErrorMessage = "Please Select a Time")]
        [Display(Name = "Time")]
        public string Time { get; set; }

        [Required(ErrorMessage = "Please Select a Day of the Week")]
        [Display(Name = "Day of the Week")]
        public string DayofWeek { get; set; }


        [Display(Name = "")]
        public string Instructor { get; set; }

        [Display(Name = "RegID")]

        public string RegID { get; set; }

        
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }



    }
}