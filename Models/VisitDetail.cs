using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NH645015_MIS4200.Models
{
    public class VisitDetail
    {
        [Key]   
        public int visitID { get; set; }
        [Display(Name = "Date of Visit")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime visitDate { get; set; }
        [Display(Name = "Price of the visit")]
        [DataType(DataType.Currency)]
        public decimal price { get; set; }

        public int petID { get; set; }
        public virtual Pet Pet { get; set; }

        public int vetID { get; set; }
        public virtual Vet Vet { get; set; }

    }
}