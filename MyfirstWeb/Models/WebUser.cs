using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyfirstWeb.Models
{
    //_______________Usando Model Binding________________________
   /* public class WebUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    */
   public class WebUser
    {
        //_____________Agregando validación básica___________
        [Display(Name = "First Name")]
        [Required(AllowEmptyStrings = true)]
        [Range(1, 5)]
        //[Required(ErrorMessage = "You must enter a value for the First Name field!")]
        //[StringLength(25, ErrorMessage = "The First Name must be no longer than 25 characters!")]
        public string FirstName { get; set; }
       
        [Required(ErrorMessage = "You must enter a value for the Last Name field!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The Last Name must be between 3 and 50 characters long!")]
        public string LastName { get; set; }
         
        [RegularExpression("[a-z]{2}-[0-9]{4}-[0-9]{4}")]
        public string MemberId { get; set; }
        //_______________DataAnnotations__________________
        /*[Required(ErrorMessage = "You must enter a value for the Mail Address field!")]
        [EmailAddress(ErrorMessage = "Please enter a valid e-mail address!")]
        public string MailAddress { get; set; }*/
        [Compare("MailAddressRepeated")]
        public string MailAddress { get; set; }
        public string MailAddressRepeated { get; set; }
    }
}
