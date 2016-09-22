using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolTHang.Models
{
    public class Classes
    {
        public Guid Id { get; set; }
        [Required]
        public String Name { get; set; }

        public Guid Fk_School { get; set; }

        [ForeignKey("Fk_School")]
        public virtual School School { get; set; }


        public virtual ICollection<User> Students { get; set; }
        public virtual ICollection<Fag> Fag { get; set; }
    }
}