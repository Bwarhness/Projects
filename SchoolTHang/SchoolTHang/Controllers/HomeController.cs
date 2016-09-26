
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolTHang.Models;
namespace SchoolTHang.Controllers
{
    public class HomeController : BaseController
    {

        public ActionResult Index()
        {
            if (Currentuser == null)
            {
                return RedirectToAction("Login");
            }
            Currentuser = DB.Users.Find(Currentuser.Id);
            MainViewModel Viewmodel = new MainViewModel();
            Viewmodel.currentuser = Currentuser;
            Viewmodel.Annoucements = DB.Annocements.Where(p => p.ID_Subject == Currentuser.AssignedClass.Id);
            Viewmodel.Arrangements = DB.Arrangements.Where(p => p.ID_Subject == Currentuser.AssignedClass.Id);
            
            return View(Viewmodel);

        }
        public ActionResult Login()
        {
            Currentuser = null;
            return View();
        }
        [HttpPost]
        public ActionResult Login(Models.User UserLogin)
        {
            var res = DB.Users.Where(p => p.Name == UserLogin.Name).FirstOrDefault();
            if (DB.Users.Where(p => p.Name == UserLogin.Name).Any())
            {
                Models.User FoundUser = DB.Users.Where(p => p.Name == UserLogin.Name).FirstOrDefault();
                if (FoundUser.Password == UserLogin.Password)
                {
                    
                    Currentuser = FoundUser;
                    return RedirectToAction("Index");
                }

            }
            return View();
        }
        public ActionResult Fag(Guid Id)
        {
            MainViewModel viewModel = new MainViewModel();
            var fag = DB.Fag.Find(Id);
            return View(fag);
        }
        public ActionResult CreateClass()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateClass(Classes FilledClass)
        {
            FilledClass.Id = Guid.NewGuid();
            FilledClass.Fk_School = Currentuser.AssignedClass.Fk_School;
            DB.Classes.Add(FilledClass);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CreateAnnoucement(Guid SubjectID)
        {
            ViewBag.SubjectID = SubjectID;
            return View();
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult CreateAnnoucement(Announcement CreatedAnnoucement)
        {
            CreatedAnnoucement.Id = Guid.NewGuid();
            CreatedAnnoucement.Created = DateTime.Now;
            DB.Annocements.Add(CreatedAnnoucement);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CreateArrangement(Guid SubjectID)
        {
            ViewBag.SubjectID = SubjectID;
            return View();
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult CreateArrangement(Arrangements CreatedArrangement)
        {
            CreatedArrangement.Id = Guid.NewGuid();
            CreatedArrangement.Created = DateTime.Now;
            DB.Arrangements.Add(CreatedArrangement);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CreateAssignment(Guid SubjectID)
        {
            ViewBag.SubjectID = SubjectID;
            return RedirectToAction("Fag", new { id= SubjectID });
        }
        public ActionResult CreateFag()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult CreateFag(Fag CreatedFag)
        {
            CreatedFag.Id = Guid.NewGuid();
            CreatedFag.Fk_class = Currentuser.Fk_AssignedClass;
            DB.Fag.Add(CreatedFag);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult CreateAssignment(Assignment CreatedAssignment)
        {
            CreatedAssignment.Id = Guid.NewGuid();
            CreatedAssignment.Created = DateTime.Now;
            DB.Assignments.Add(CreatedAssignment);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }

        public HomeController()
        {
            this.mainLayoutViewModel = new MainLayoutViewModel();//has property PageTitle
            this.mainLayoutViewModel.Currentuser = Currentuser;

            this.ViewData["MainLayoutViewModel"] = this.mainLayoutViewModel;
        }
    }
}