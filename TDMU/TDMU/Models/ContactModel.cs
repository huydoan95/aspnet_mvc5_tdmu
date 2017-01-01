using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDMU.Models
{
    public class ContactModel
    {
        [Display(Name = "Your name ")]
        [Required(ErrorMessage = "The Name may not be empty")]
        public string UserName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email can not be empty")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email incorrect")]
        public string Email { get; set; }

        [Display(Name = "Your phone number")]
       // [RegularExpression(@"^\(+84[\-\s])\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered mobile format is not valid.")]
        [RegularExpression(@"^(?:\d{9}|00\d{10}|\d{10}|\d{11}|\+\d{11}|\+\d{12})$", ErrorMessage = "You must provide a proper phone number.")]
        //[RegularExpression(@"?\d{9,10}|\+\d{11,12}",ErrorMessage = "Entered mobile format is not valid.")]
        // [DataType(DataType.PhoneNumber, ErrorMessage = "wrong format")]
        //(\+84[\-\s])\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$
        //[RegularExpression(@"((\+*)((0[ -]+)*|(84 )*)(\d{12}+|\d{11}+))|\d{5}([- ]*)\d{6}",ErrorMessage ="hehe")]
        public string Phone { set; get; }

        [Display(Name = "Title for message")]
        [Required(ErrorMessage = "Titles can not be blank")]
        public string Subject { get; set; }

        [Display(Name = "Content")]
        [Required(ErrorMessage = "Please enter text")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}
