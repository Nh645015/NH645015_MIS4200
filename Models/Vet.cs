using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NH645015_MIS4200.Models
{
    public class Vet
    {
        public int vetID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public ICollection<VisitDetail> VisitDetail { get; set; }
    }
}