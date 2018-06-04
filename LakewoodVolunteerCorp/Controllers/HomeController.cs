using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LakewoodVolunteerCorp.DAL;
using LakewoodVolunteerCorp.ViewModels;

namespace LakewoodVolunteerCorp.Controllers
{
    public class HomeController : Controller
    {
        private NonProfitContext db = new NonProfitContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            IQueryable<SignUpDateGroup> data = from volunteer in db.Volunteers
                                                   group volunteer by volunteer.SignUpDate into dateGroup
                                                   select new SignUpDateGroup()
                                                   {
                                                       SignUpDate = dateGroup.Key,
                                                       VolunteerCount = dateGroup.Count()
                                                   };
            return View(data.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Please let us know if you would like to volunteer!";

            return View();
        }
    }
}