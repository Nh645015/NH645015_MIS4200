using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NH645015_MIS4200.Models
{
    public class Product
    {
        public int productID { get; set; }
        public string description { get; set; }
        public decimal unitCost { get; set; }
        public int supplierID { get; set; }

        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<orderDetail> OrderDetail { get; set; }
    }
}