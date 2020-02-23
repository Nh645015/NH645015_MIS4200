using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NH645015_MIS4200.Models
{
    public class Pet
    {
        [Key]
        public int petID { get; set; }
        [Display(Name = "Pets Name")]
        [Required(ErrorMessage = "Please enter in your pets name")]
        [StringLength(20)]
        public string petName { get; set; }
        [Display(Name = "Breed of pet")]
        [Required(ErrorMessage = "Please enter in your pets breed")]
        [StringLength(20)]
        public string petBreed { get; set; }
        [Display(Name = "Type of pet (Cat or Dog)")]
        [Required(ErrorMessage = "Please provide if your pet is either a cat or dog")]
        [StringLength(3)]
        public string petType { get; set; }


        public ICollection<VisitDetail> VisitDetail { get; set; }

        public int customerID { get; set; }
        public virtual Customer Customer { get; set; }

    }
}