using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NH645015_MIS4200.Models
{
    public class Vet
    {
        public int vetID { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter in your first name")]
        [StringLength(20)]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter in your last name")]
        [StringLength(20)]
        public string lastName { get; set; }
        [Display(Name = "Office Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage = "Phone numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string Phone { get; set; }

        public string fullName { get { return lastName + ", " + firstName; } }

        public ICollection<VisitDetail> VisitDetail { get; set; }
    }
}