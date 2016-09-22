using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolTHang.Models
{
    public class MainLayoutViewModel
    {
        public User Currentuser { get; set; }
        public List<Classes> Classes { get; set; }
    }
}