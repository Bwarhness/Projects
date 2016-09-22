using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolTHang.Models
{
    public class User
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        public bool IsTeacher { get; set; }
        public Guid Fk_AssignedClass { get; set; }
        [ForeignKey("Fk_AssignedClass")]
        public virtual Classes AssignedClass { get; set; }
    }
}