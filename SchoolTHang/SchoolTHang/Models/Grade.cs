using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolTHang.Models
{
    public class Grade
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Delivered { get; set; }
        public string Content { get; set; }
        public int grade { get; set; }
        //Todo Files

        //TODO assignment
        public Guid ID_Subject { get; set; } 
    }
}