using JsonVeriCekme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JsonVeriCekme.Controllers
{
    public class HomeController : Controller
    {
        private NORTHWNDdbEntities db = new NORTHWNDdbEntities();

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetProducts()
        {
            db.Configuration.ProxyCreationEnabled = false; //veritabanında bilgi okuyup parse edeceksin. Bunun için proxy oluşturmadan mevcut yapıyı kullan demek.

            List<Products> product = db.Products.ToList();
            return Json(product, JsonRequestBehavior.AllowGet);

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