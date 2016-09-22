using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolTHang.Models
{
    public class Fag
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public Guid Fk_class { get; set; }

        [ForeignKey("Fk_class")]
        public virtual Classes Class { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }

    }
}