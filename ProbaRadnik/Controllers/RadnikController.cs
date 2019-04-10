using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProbaRadnik.Models;

namespace ProbaRadnik.Controllers
{
    public class RadnikController : Controller
    {
        // GET: Radnik
        public ActionResult GetView()
        {
            Radnik radnik = new Radnik();
            radnik.Ime = "Petar";
            radnik.Prezime = "Petrovic";
            radnik.Plata = 180000;
            return View("RadnikView", radnik);
        }
    }
}