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
        public string petName { get; set; }
        public string petBreed { get; set; }

        public ICollection<VisitDetail> VisitDetail { get; set; }

        public int customerID { get; set; }
        public virtual Customer Customer { get; set; }

    }
}