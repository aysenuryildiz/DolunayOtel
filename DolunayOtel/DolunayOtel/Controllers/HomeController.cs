using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DolunayOtel.Controllers
{

    public class HomeController : Controller
    {
        RezervasyonSistemiEntities db = new RezervasyonSistemiEntities();



        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Felsefe()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Hizmet()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Odalar()
        {

            var liste = db.Oda.Where(x => x.GirisTarihi < DateTime.Now && x.CikisTarihi > DateTime.Now).OrderByDescending(x => x.OdaID);
            return View();
        }
        public ActionResult Fiyat()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Galeri()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Iletisim()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Rezerve()
        {
        
            return View();
        }
        public ActionResult ChangeCulture(string lang, string returnUrl)
        {
            Session["Culture"] = new CultureInfo(lang);
            return Redirect(returnUrl);
        }
    }
}