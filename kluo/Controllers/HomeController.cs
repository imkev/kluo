using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kluo.Models;

namespace kluo.Controllers
{
    public class HomeController : Controller
    {

        kluoDb _db = new kluoDb();

        public ActionResult Index()
        {
            //var controller = RouteData.Values["controller"];
            //var action = RouteData.Values["action"];
            //var id = RouteData.Values["id"];

            //var message = string.Format("{0}::{1} {2}", controller, action, id);

            //ViewBag.Message = message;

            var model = _db.Restaurants.ToList();

            return View(model);
        }

        public ActionResult About()
        {
            // ViewBag.Message = "Your app description page.";
            var model = new AboutModel {Name = "Kevin", Location = "Zhuhai, China"};

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
