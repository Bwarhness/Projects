using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolTHang.Models
{
    public class Arrangements
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Deadline { get; set; }
        public string Content { get; set; }

        //Ie Class or Fag
        public Guid ID_Subject { get; set; }
    }
}