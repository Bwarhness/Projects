using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolTHang.Models;

namespace SchoolTHang.Controllers
{
    public class BaseController : Controller
    {
        public DataContext DB = new DataContext();
        public static User Currentuser;

        public MainLayoutViewModel MainLayoutViewModel { get; set; }




        
        // GET: Base

    }
}