using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolTHang.Models
{
    public class School
    {
        public Guid Id { get; set; }
        [Required]
        public String Name { get; set; }

        public virtual ICollection<Classes> Classes { get; set; }
    }
}