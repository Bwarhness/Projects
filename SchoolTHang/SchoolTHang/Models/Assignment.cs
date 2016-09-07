using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolTHang.Models
{
    public class Assignment
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Deadline { get; set; }

        public string Description { get; set; }

       
        

        public virtual Fag Fag { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
    }
}