using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolTHang.Models
{
    public class Fag
    {
        public Guid Id { get; set; }
        public String Name { get; set; }

        public virtual Classes Class { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }

    }
}