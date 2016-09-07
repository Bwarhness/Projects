using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolTHang.Models
{
    public class MainViewModel
    {
        public User currentuser { get; set; }
        public Classes CurrentClass { get; set; }
        public Fag Fag { get; set; }
        public IEnumerable<Announcement> Annoucements { get; set; }
        public IEnumerable<Arrangements> Arrangements { get; set; }
        public IEnumerable<Assignment> Assignments { get; set; }
    }

}