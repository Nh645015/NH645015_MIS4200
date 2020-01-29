using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NH645015_MIS4200.Models
{
    public class Orders
    {
        [Key]
        public int orderNum { get; set; }
        public string description { get; set; }
        public DateTime orderDate { get; set; }
        public int customerID { get; set; }
        public virtual customer customer { get; set; }
    }

}