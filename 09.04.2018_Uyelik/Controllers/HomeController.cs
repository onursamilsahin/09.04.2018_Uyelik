using _09._04._2018_Uyelik.Models.Context;
using _09._04._2018_Uyelik.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _09._04._2018_Uyelik.Controllers
{
    public class HomeController : Controller
    {
    
        public ActionResult Index()
        {

        DBCONTEXT db = new DBCONTEXT();
            List<Makale> makale = db.Makale.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        { 
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}