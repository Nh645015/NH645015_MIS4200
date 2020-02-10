using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NH645015_MIS4200.Models
{
    public class Customer
    {
        public int customerID { get; set; }
        [Display (Name="First Name")]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Display(Name = "Most used email")]
        public string email { get; set; }
        [Display(Name = "Mobile phone number")]
        public string phone { get; set; }
        [Display(Name = "Customer Since")]
        public DateTime customerSince { get; set; }

        public ICollection<Pet> Pet { get; set; }
    }
}